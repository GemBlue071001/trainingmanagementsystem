using Application.Interfaces;
using Application.Utils;
using Application.ViewModels.Syllabus;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using FluentValidation;
using System.Linq.Expressions;

namespace Application.Services
{
    public class SyllabusService : ISyllabusService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        private readonly ServiceResponse _serviceResponse;
        private IValidator<SyllabusCreateDTO> _syllabusCreateValidator;
        public SyllabusService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _serviceResponse = new ServiceResponse();
        }

        public async Task<ServiceResponse> GetAllSyllabusAdvanceAsync(
            Expression<Func<Syllabus, bool>> filter = null,
            int pageSize = 0,
            int pageIndex = 1,
            SortType sortType = SortType.Ascending)
        {
            if (pageSize < 0 || pageIndex < 1)
            {

                return _serviceResponse.Fail("Syllabus not found");

            }
            var result = await _unitOfWork.Syllabuses.GetAllAdvanceAsync<string>(
                filter,
                pageSize,
                pageIndex,
                keySelectorForSort: x => x.Name,
                sortType
                );
            return _serviceResponse.Success(result);

        }

        public async Task<ServiceResponse> GetSyllabusByIdAsync(int id, int time)
        {
            var syllabus = await _unitOfWork.Syllabuses.GetSyllabusRelationUnitAsync(id);
            if (syllabus == null)
            {
                return _serviceResponse.Fail("Syllabus not found");
            }
            var result = _mapper.Map<SyllabusViewDTO>(syllabus);
            if (time == 1)
            {
                result.Duration /= 60;
                result.TimeType = TimeType.hour;
            }
            return _serviceResponse.Success(result);
        }

        public async Task<ServiceResponse> CreateSyllabusAsync(SyllabusCreateDTO syllabusDto)
        {
            //TODO Check order/day
            var model = _mapper.Map<Syllabus>(syllabusDto);
            await _unitOfWork.Syllabuses.AddAsync(model);
            await _unitOfWork.SaveChangesAsync();
            return _serviceResponse.Success(_mapper.Map<SyllabusViewDTO>(model));
        }
        public async Task<ServiceResponse> UpdateSyllabusAsync(SyllabusUpdateDTO syllabusDto)
        {
            var syllabus = await _unitOfWork.Syllabuses.GetSyllabusRelationUnitAsync(syllabusDto.Id);

            if (syllabus == null)
                return _serviceResponse.Fail("Not found");

            // Update syllabus properties
            syllabus.Name = syllabusDto.Name;
            syllabus.Code = syllabusDto.Code;
            syllabus.TrainingDeliveryPrinciple = syllabusDto.TrainingDeliveryPrinciple;
            syllabus.SyllabusLevel = syllabusDto.SyllabusLevel;
            syllabus.AttendeeNumber = syllabusDto.AttendeeNumber;
            syllabus.TechnicalRequirement = syllabusDto.TechnicalRequirement;
            syllabus.CourseObjective = syllabusDto.CourseObjective;
            syllabus.Version = syllabusDto.Version;
            syllabus.QuizSchema = syllabusDto.QuizSchema;
            syllabus.AssignmentSchema = syllabusDto.AsignmentSchema;
            syllabus.FinalSchema = syllabusDto.FinalSchema;
            syllabus.FinalTheorySchema = syllabusDto.FinalTheorySchema;
            syllabus.FinalPracticeSchema = syllabusDto.FinalPraticeSchema;
            syllabus.GPASchema = syllabusDto.GPASchema;

            foreach (var updatedUnit in syllabusDto.Units)
            {
                // Try to find the corresponding unit in the user's syllabus
                var userUnit = syllabus.Units.SingleOrDefault(u => u.Name == updatedUnit.Name);

                if (userUnit == null && updatedUnit.Id == 0)
                {
                    // Unit not found in the user's syllabus, so add it
                    var modelUnit = _mapper.Map<Unit>(updatedUnit);
                    syllabus.Units.Add(modelUnit);
                }
                else
                {
                    // Update the unit's properties
                    userUnit.Day = updatedUnit.Day;
                    userUnit.SortOrder = updatedUnit.SortOrder;

                    // Update each unit lesson in the unit
                    foreach (var updatedUnitLesson in updatedUnit.UnitLessons)
                    {
                        // Try to find the corresponding unit lesson in the user's unit
                        var UnitLesson = userUnit.UnitLessons.SingleOrDefault(u => u.Name == updatedUnitLesson.Name);

                        if (UnitLesson == null)
                        {
                            // Unit lesson not found in the user's unit, so add it
                            var modelUnitLessons = _mapper.Map<UnitLesson>(updatedUnitLesson);
                            userUnit.UnitLessons.Add(modelUnitLessons);
                        }
                        else
                        {
                            // Update the unit lesson's properties
                            UnitLesson.Duration = updatedUnitLesson.Duration;
                            UnitLesson.LessonType = updatedUnitLesson.LessonType;
                            UnitLesson.DeliveryType = updatedUnitLesson.DeliveryType;
                            var modelOutputStandard = _mapper.Map<OutputStandard>(updatedUnitLesson.OutputStandard);
                            UnitLesson.OutputStandard = modelOutputStandard;

                            // Update each training material in the unit lesson
                            foreach (var updatedTrainingMaterial in updatedUnitLesson.TrainingMaterial)
                            {
                                // Try to find the corresponding training material in the user's unit lesson
                                var userTrainingMaterial = UnitLesson.TrainingMaterials
                                    .SingleOrDefault(t => t.FileName == updatedTrainingMaterial.FileName);

                                if (userTrainingMaterial == null)
                                {
                                    // Training material not found in the user's unit lesson, so add it
                                    var modelTrainingMaterial = _mapper.Map<TrainingMaterial>(updatedTrainingMaterial);
                                    UnitLesson.TrainingMaterials.Add(modelTrainingMaterial);
                                }
                                else
                                {
                                    // Update the training material's file link
                                    userTrainingMaterial.FileLink = updatedTrainingMaterial.FileLink;
                                }
                            }
                            // Remove any training material in the unit lesson that is not in the updated unit lesson
                            var trainingMaterialToRemoves = UnitLesson.TrainingMaterials.Where(t => !updatedUnitLesson.TrainingMaterial.Any(u => u.FileName == t.FileName)).ToList();
                            foreach (var trainingMaterialToRemove in trainingMaterialToRemoves)
                            {
                                UnitLesson.TrainingMaterials.Remove(trainingMaterialToRemove);
                            }
                        }
                    }
                    // Remove any unit lesson in the unit that is not in the updated unit
                    var unitsLessonsToRemoves = userUnit.UnitLessons.Where(u => !updatedUnit.UnitLessons.Any(up => up.Name == u.Name)).ToList();
                    foreach (var unitLessonToRemove in unitsLessonsToRemoves)
                    {
                        userUnit.UnitLessons.Remove(unitLessonToRemove);
                    }
                }
            }
            // Remove any unit in the syllabus that is not in the updated syllabus
            var unitsToRemoves = syllabus.Units.Where(u => !syllabusDto.Units.Any(up => up.Name == u.Name)).ToList();
            foreach (var unitToRemove in unitsToRemoves)
            {
                syllabus.Units.Remove(unitToRemove);
            }
            // Save changes to the database
            await _unitOfWork.SaveChangesAsync();
            return _serviceResponse.Success();
        }

        public async Task<ServiceResponse> RemoveSyllabusAsync(int id)
        {

            var syllabus = await _unitOfWork.Syllabuses.GetAsync(x=>x.Id == id);
            if (syllabus == null)
            {
                return _serviceResponse.Fail("Not found");
            }
            await _unitOfWork.Syllabuses.RemoveAsync(syllabus);
            await _unitOfWork.SaveChangesAsync();
            return _serviceResponse.Success();
        }

        public async Task<ServiceResponse> GetAverageOfStudentInSyllabusAsync(int idSyllabus,int idStudent)
        {

            var studentAssignment = await _unitOfWork.StudentAssignments.GetStudentAssignmentByIdStudentAsync(x => x.StudentId == idStudent && x.Assignment.SyllabusId == idSyllabus);
            if (studentAssignment == null)
            {
                return _serviceResponse.Fail("Not found");
            }
             var getSyllabus = await _unitOfWork.Syllabuses.GetAsync(x=>x.Id == idSyllabus);
             var getRatio = new
             {
                 QuizSchema = getSyllabus.QuizSchema,
                 AsignmentScheme = getSyllabus.AssignmentSchema,
                 FinalScheme = getSyllabus.FinalSchema,
                 FinalTheoryScheme = getSyllabus.FinalTheorySchema,
                 FinalPractice = getSyllabus.FinalPracticeSchema
             };
            double averageQuiz = 0;
            double averageAssignment = 0;
            double averageFinalTheory = 0;
            double averageFinalPractice = 0;

            int demQuiz = 0;
            int demAssignment = 0;
            int demFinalTheory = 0;
            int demFinalPractice = 0;
            //Calculator sum of type from studentAssignment
            foreach (var item in studentAssignment)
            {
                switch (item.Assignment.Type)
                {
                    case AssignmentType.Quiz:
                        averageQuiz += (double)(item.Score);
                        demQuiz++;
                        break;
                    case AssignmentType.Assignment:
                        averageAssignment += (double)(item.Score);
                        demAssignment++;
                        break;
                    case AssignmentType.FinalTheory:
                        averageFinalTheory += (double)(item.Score);
                        demFinalTheory++;
                        break;
                    case AssignmentType.FinalPractice:
                        averageFinalPractice += (double)(item.Score);
                        demFinalPractice++;
                        break;
                    default:
                        break;
                }
            }
            //Calculator average % from syllabus
            averageQuiz = averageQuiz/demQuiz * getRatio.QuizSchema;
            averageAssignment = averageAssignment / demAssignment * getRatio.AsignmentScheme;
            averageFinalTheory = averageFinalTheory / demFinalTheory * getRatio.FinalTheoryScheme;
            averageFinalPractice = averageFinalPractice / demFinalPractice * getRatio.FinalPractice;

            return _serviceResponse.Success((double)(((averageQuiz + averageAssignment) / 100
                + ((averageFinalTheory + averageFinalPractice) /100 * getRatio.FinalScheme / 100))));
        }
        public async Task<ServiceResponse> GetAverageOfAllStudentInSyllabusAsync(int idSyllabus)
        {
            var syllabus = await _unitOfWork.Syllabuses.GetSyllabusRelationAssignmentAsync(idSyllabus);

            if (syllabus == null)
            {
                return _serviceResponse.Fail("Not found");
            }

            var assignments = syllabus.Assignments.SelectMany(a => a.StudentAssignments);

            if (!assignments.Any())
            {
                return _serviceResponse.Fail("No student assignments found for this syllabus");
            }

            var quizAssignments = assignments.Where(a => a.Assignment.Type == AssignmentType.Quiz);
            var assignmentAssignments = assignments.Where(a => a.Assignment.Type == AssignmentType.Assignment);
            var finalTheoryAssignments = assignments.Where(a => a.Assignment.Type == AssignmentType.FinalTheory);
            var finalPracticeAssignments = assignments.Where(a => a.Assignment.Type == AssignmentType.FinalPractice);

            double quizAverage = (double)quizAssignments.Average(a => a.Score);
            double assignmentAverage = (double)assignmentAssignments.Average(a => a.Score);
            double finalTheoryAverage = (double)finalTheoryAssignments.Average(a => a.Score);
            double finalPracticeAverage = (double)finalPracticeAssignments.Average(a => a.Score);

            var getRatio = new
            {
                QuizSchema = syllabus.QuizSchema,
                AssignmentScheme = syllabus.AssignmentSchema,
                FinalScheme = syllabus.FinalSchema,
                FinalTheoryScheme = syllabus.FinalTheorySchema,
                FinalPracticeScheme = syllabus.FinalPracticeSchema
            };

            double weightedQuizAverage = quizAverage * getRatio.QuizSchema;
            double weightedAssignmentAverage = assignmentAverage * getRatio.AssignmentScheme;
            double weightedFinalTheoryAverage = finalTheoryAverage * getRatio.FinalTheoryScheme;
            double weightedFinalPracticeAverage = finalPracticeAverage * getRatio.FinalPracticeScheme;



            /*(double)(((averageQuiz + averageAssignment) / 100
                + ((averageFinalTheory + averageFinalPractice) / 100 * getRatio.FinalScheme / 100)));*/

            double overallAverage = (double)(((weightedQuizAverage + weightedAssignmentAverage) / 100
                + ((weightedFinalTheoryAverage + weightedFinalPracticeAverage) / 100 * getRatio.FinalScheme / 100)));

            return _serviceResponse.Success(overallAverage);
        }
    }
}

