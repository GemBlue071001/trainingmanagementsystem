using Application.Interfaces;
using Application.Utils;
using Application.ViewModels;
using Application.ViewModels.TrainingProgramViewModels;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using FluentValidation;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace Application.Services
{
    public class TrainingProgramService: ITrainingProgramService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IValidator<TrainingProgram> _validator;
        private readonly ServiceResponse _serviceResponse;

        public TrainingProgramService(IUnitOfWork unitOfWork, IMapper mapper, IValidator<TrainingProgram> validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validator = validator;
            _serviceResponse = new ServiceResponse();
        }

        public async Task<ServiceResponse> GetAllTrainingProgramAdvanceAsync(
            Expression<Func<TrainingProgram, bool>> filter = null,
            int pageSize = 0,
            int pageIndex = 1,
            SortType sortType = SortType.Ascending)
        {
            if (pageSize < 0 || pageIndex < 1)
            {

                return _serviceResponse.Fail("Training Program not found");

            }
            var result = await _unitOfWork.TrainingPrograms.GetAllAdvanceAsync<string>(
                filter,
                pageSize,
                pageIndex,
                keySelectorForSort: x => x.Name,
                sortType
                );
            return _serviceResponse.Success(result);

        }
        public async Task<ServiceResponse> GetAllTrainingProgramsWithProgramSyllabusAdvanceAsync(
            Expression<Func<TrainingProgram, bool>> filter = null,
            int pageSize = 0, 
            int pageIndex = 1, 
            SortType sortType = SortType.Ascending)
        {
            if (pageSize < 0 || pageIndex < 1)
            {

                return _serviceResponse.Fail("Training Program not found");

            }
            var trainingProgramList = await _unitOfWork.TrainingPrograms.GetAllTrainingProgramsWithProgramSyllabusAsync<string>(
                filter,
                pageSize,
                pageIndex,
                keySelectorForSort: x => x.Name,
                sortType
                );

            var result = _mapper.Map<List<TrainingProgramViewDTO>>(trainingProgramList);
            return _serviceResponse.Success(result);
        }

        public async Task<ServiceResponse> GetTrainingProgramByIdAsync(int id)
        {
            var trainingProgram = await _unitOfWork.TrainingPrograms.GetTrainingProgramWithProgramSyllabusAsync(x => x.Id == id && x.IsDeleted == false);
            var result = _mapper.Map<TrainingProgramViewDTO>(trainingProgram);
            if (trainingProgram == null)
            {
                return _serviceResponse.Fail("Training Program not found");
            }
            return _serviceResponse.Success(result);
        }

        public async Task<ServiceResponse> CreateTrainingProgramAsync(TrainingProgramCreateDTO trainingProgramDTO)
        {
            var newTrainingProgram = _mapper.Map<TrainingProgram>(trainingProgramDTO);

            var validatorResult = _validator.Validate(newTrainingProgram);
            if (!validatorResult.IsValid)
            {
                return _serviceResponse.Fail(validatorResult.ToString("\n"));
                         }
            await _unitOfWork.TrainingPrograms.AddAsync(newTrainingProgram);
            await _unitOfWork.SaveChangesAsync();
            return _serviceResponse.Success();
        }

        public async Task<ServiceResponse> DeleteTrainingProgramAsync(int id)
        {
            var oldTrainingProgram = await _unitOfWork.TrainingPrograms.GetAsync(x => x.Id == id, true);
            if (oldTrainingProgram == null || oldTrainingProgram.IsDeleted == true)
            {
                return _serviceResponse.Fail("Training Program not found");
            }
            oldTrainingProgram.IsDeleted = true;
            await _unitOfWork.SaveChangesAsync();
            return _serviceResponse.Success();
        }
        public async Task<ServiceResponse> UpdateTrainingProgramAsync(TrainingProgramUpdateDTO trainingProgramDTO)
        {
            var oldTrainingProgram = await _unitOfWork.TrainingPrograms.
                                    GetTrainingProgramWithProgramSyllabusAsync(x => x.Id == trainingProgramDTO.Id, true);
            if (oldTrainingProgram == null || oldTrainingProgram.IsDeleted == true)
            {
                return _serviceResponse.Fail("Training Program not found");
            }
            foreach (var item in oldTrainingProgram.ProgramSyllabuses)
            {
                oldTrainingProgram.ProgramSyllabuses.Remove(item);
            }
            foreach (var item in trainingProgramDTO.ProgramSyllabuses)
            {
                oldTrainingProgram.ProgramSyllabuses.Add(new ProgramSyllabus { SyllabusId = item.SyllabusId});
            }
            oldTrainingProgram.Name = trainingProgramDTO.Name;
            oldTrainingProgram.CreatedOn = trainingProgramDTO.CreatedOn;
            oldTrainingProgram.CreatedByUserId = trainingProgramDTO.CreatedByUserId;
            oldTrainingProgram.ModifiedOn = trainingProgramDTO.ModifiedOn;
            oldTrainingProgram.ModifiedByUserId = trainingProgramDTO.ModifiedByUserId;
            oldTrainingProgram.ParentId = trainingProgramDTO.ParentId;
            oldTrainingProgram.Status = trainingProgramDTO.Status;

            await _unitOfWork.SaveChangesAsync();
            return _serviceResponse.Success();
        }
        public async Task<ServiceResponse> AddOneSyllabusToTrainingProgramAsync(int syllabusId, int trainingProgramId)
        {
            var trainingProgram = await _unitOfWork.TrainingPrograms.
                                    GetTrainingProgramWithProgramSyllabusAsync(x => x.Id == trainingProgramId);
            var syllabus = await _unitOfWork.Syllabuses.
                                    GetAsync(x => x.Id == syllabusId);
            if (trainingProgram == null || trainingProgram.IsDeleted == true)
            {
                return _serviceResponse.Fail("Training Program not found");
            }
            if (syllabus == null || syllabus.IsDeleted == true)
            {
                return _serviceResponse.Fail("Syllabus not found");
            }
            foreach (var item in trainingProgram.ProgramSyllabuses)
            {
                if (item.SyllabusId == syllabusId && item.TrainingProgramId == trainingProgramId)
                {
                    return _serviceResponse.Fail("This Training Program already has this Syllabus");
                }
            }
            trainingProgram.ProgramSyllabuses.Add(new ProgramSyllabus
            {
                SyllabusId = syllabusId,
                TrainingProgramId = trainingProgramId
            });
            await _unitOfWork.SaveChangesAsync();
            return _serviceResponse.Success();
        }

        public async Task<ServiceResponse> RemoveOneSyllabusToTrainingProgramAsync(int syllabusId, int trainingProgramId)
        {
            var trainingProgram = await _unitOfWork.TrainingPrograms.
                                    GetTrainingProgramWithProgramSyllabusAsync(x => x.Id == trainingProgramId);
            var syllabus = await _unitOfWork.Syllabuses.
                                    GetAsync(x => x.Id == syllabusId);
            //bool trainingProgramIncludeSyllabus = false;

            if (trainingProgram == null || trainingProgram.IsDeleted == true)
            {
                return _serviceResponse.Fail("Training Program not found");
            }
            if (syllabus == null || syllabus.IsDeleted == true)
            {
                return _serviceResponse.Fail("Syllabus not found");
            }
            var programSyllabus = await _unitOfWork.ProgramSyllabus.GetAsync(x => x.SyllabusId == syllabusId && x.TrainingProgramId == trainingProgramId
                                                                                && x.IsDeleted == false, true);
            if (programSyllabus == null)
            {
                return _serviceResponse.Fail("Program Syllabus not found");
            }
            await _unitOfWork.ProgramSyllabus.RemoveAsync(programSyllabus);
            await _unitOfWork.SaveChangesAsync();
            return _serviceResponse.Success();
        }
    }
}