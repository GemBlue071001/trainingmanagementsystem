using Application.Commons;
using Application.Interfaces;
using Application.ViewModels.TrainingClasses;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class TrainingClassService : ITrainingClassService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public TrainingClassService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Pagination<TrainingClassViewDTO>> GetClassesAysnc(int pageIndex,
            int pageSize,
            string search,
            DateTime createOnStart,
            DateTime createOnEnd)
        {
            var listOfClass = await _unitOfWork.TrainingClass.GetTrainingClassPaging(pageIndex, pageSize, search, createOnStart, createOnEnd);
            int count = await _unitOfWork.TrainingClass.CountTrainingClass(pageIndex, pageSize, search, createOnStart, createOnEnd);

            var listOfClassResponse = _mapper.Map<List<TrainingClassViewDTO>>(listOfClass);


            var paginatedListClass = new Pagination<TrainingClassViewDTO>(listOfClassResponse, count, pageIndex, pageSize);
            return paginatedListClass;

        }

        public async Task CreateClassAsync(TrainingClassCreateDTO createDTO)
        {
            var _trainingClass = _mapper.Map<TrainingClass>(createDTO);
            string code = await GenerateClassCode(createDTO);
            _trainingClass.ClassCode = code;
            await _unitOfWork.TrainingClass.AddAsync(_trainingClass);
            await _unitOfWork.SaveChangesAsync();
        }


        public async Task<string> GenerateClassCode(TrainingClassCreateDTO classDTO)
        {
            string hcmCode = classDTO.ClassLocation.ToString();
            string year = DateTime.Now.Year.ToString().Substring(2);
            string frCode = classDTO.AttendeeType switch
            {
                AttendeeType.Intern => "IN",
                AttendeeType.Fresher => "FR",
                AttendeeType.OnlineFeeFresher => "OF",
                AttendeeType.OfflineFeeFresher => "FF",
                _ => throw new ArgumentException($"Unknown AttendeeType: {classDTO.AttendeeType}")
            };
            string oCode = classDTO.ClassTimeStart.ToString("o").Substring(11, 1);
            int sequenceNumber = await _unitOfWork.TrainingClass.CountAllTrainingClassAsync();
            string classCode = $"{hcmCode}{year}_{frCode}.{oCode}_{classDTO.ClassName}_{sequenceNumber.ToString()}";
            return classCode;
        }

        public async Task UpdateClassStatusAsync(TrainingClassStatusUpdateDTO updateDTO)
        {
            var _trainingClass = await _unitOfWork.TrainingClass.GetAsync(b => b.Id == updateDTO.TrainingClassId);
            _trainingClass.Status = updateDTO.Status;
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateClassReviewerAsync(TrainingClassReviewUpdateDTO updateDTO)
        {
            var _trainingClass = await _unitOfWork.TrainingClass.GetAsync(b => b.Id == updateDTO.TrainingClassId);
            _trainingClass.UserReviewedId = updateDTO.UserReviewedId;
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateClassInfomationAsync(TrainingClassInfomationUpdateDTO updateDTO)
        {
            var _trainingClass = await _unitOfWork.TrainingClass.GetAsync(b => b.Id == updateDTO.TrainingClassId);
            // update Field
            _trainingClass.ClassTimeStart = updateDTO.ClassTimeStart;
            _trainingClass.ClassTimeEnd = updateDTO.ClassTimeEnd;
            _trainingClass.AttendeeType = updateDTO.AttendeeType;
            _trainingClass.NumberAttendeePlanned = updateDTO.NumberAttendeePlanned;
            _trainingClass.NumberAttendeeAccepted = updateDTO.NumberAttendeeAccepted;
            _trainingClass.NumberAttendeeActual = updateDTO.NumberAttendeeActual;
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<TrainingClassViewDetailDTO> GetTrainingClassDetailAsync(int id)
        {
            var _class = await _unitOfWork.TrainingClass.GetTrainingClassDetail(id);
            var _classResponse = _mapper.Map<TrainingClassViewDetailDTO>(_class);
            return _classResponse;
        }

        public async Task SoftDeleteClassAsync(int id)
        {
            var _class = await _unitOfWork.TrainingClass.GetTrainingClassWithCloseRelation(id);
            if (_class == null) throw new NullReferenceException($"Can not find class {id}");
            _class.IsDeleted = true;
            _class.TrainingProgram.IsDeleted = true;
            foreach (var assignment in _class.Assignments)
            {
                assignment.IsDeleted = true;
            }
            foreach (var admin in _class.Admins)
            {
                admin.IsDeleted = true;
            }
            foreach (var unitClassDetail in _class.UnitClassDetails)
            {
                unitClassDetail.IsDeleted = true;
            }
            await _unitOfWork.SaveChangesAsync();
        }
        public async Task RestoreClassAsync(int id)
        {
            var _class = await _unitOfWork.TrainingClass.GetTrainingClassWithCloseRelation(id);
            if (_class == null) throw new NullReferenceException($"Can not find class {id}");
            _class.IsDeleted = false;
            _class.TrainingProgram.IsDeleted = false;
            foreach (var assignment in _class.Assignments)
            {
                assignment.IsDeleted = false;
            }
            foreach (var admin in _class.Admins)
            {
                admin.IsDeleted = false;
            }
            foreach (var unitClassDetail in _class.UnitClassDetails)
            {
                unitClassDetail.IsDeleted = false;
            }
            await _unitOfWork.SaveChangesAsync();
        }



    }
}
