using Application.Commons;
using Application.Interfaces;
using Application.Utils;
using Application.ViewModels.Student;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ServiceResponse _serviceResponse;

        public StudentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _serviceResponse = new ServiceResponse();
        }

        public async Task<Pagination<StudentDTO>> GetAllStudentInClass(int classId, int pageSize = 0, int pageIndex = 1, SortType sortType = SortType.Ascending)
        {
            var listStudent = await _unitOfWork.Students.GetAllAdvanceAsync(x => x.TrainingClassId == classId, pageSize, pageIndex, x=> x.Id, sortType);
            var numberOfStudent = await _unitOfWork.Students.CountNumberOfElement(x => x.TrainingClassId == classId);

            var listStudentDTO = _mapper.Map<List<StudentDTO>>(listStudent);

            var paginatedListStudent = new Pagination<StudentDTO>(listStudentDTO, numberOfStudent, pageIndex, pageSize);
            return paginatedListStudent;
        }

        public async Task<ServiceResponse> GetStudentById(int id)
        {
            var student = await _unitOfWork.Students.GetAsync(x => x.Id == id);
            if (student == null)
            {
                return _serviceResponse.Fail("Student not found");
            }
            var studentDto = _mapper.Map<StudentDTO>(student);
            return _serviceResponse.Success(studentDto);
        }

        public async Task<ServiceResponse> CreateStudent(StudentCreateDTO studentCreateDTO)
        {
            bool IsExisted = await _unitOfWork.TrainingClass.AnyAsync(x => x.Id == studentCreateDTO.TrainingClassId);
            if (!IsExisted) return _serviceResponse.Fail("Training Class Not Found");

            var student = _mapper.Map<Student>(studentCreateDTO);
            await _unitOfWork.Students.AddAsync(student);
            await _unitOfWork.SaveChangesAsync();

            var studentDTO = _mapper.Map<StudentDTO>(student);
            return _serviceResponse.Success(studentDTO);
        }

        public async Task<ServiceResponse> SoftDeleteStudent(int id)
        {
            var student = await _unitOfWork.Students.GetAsync(x => x.Id == id);
            if (student == null)
            {
                return _serviceResponse.Fail("Student not found");
            }
            student.IsDeleted = true;
            var listAssignment = await _unitOfWork.StudentAssignments.GetAllAsync(x => x.StudentId == id);
            foreach (var assignment in listAssignment)
            {
                assignment.IsDeleted = true;
            }
            await _unitOfWork.SaveChangesAsync();
            return _serviceResponse.Success();
        }

        
        public async Task<ServiceResponse> UpdateStudent(StudentUpdateDTO studentUpdateDTO)
        {
            var student = await _unitOfWork.Students.GetAsync(x => x.Id == studentUpdateDTO.Id);
            if (student == null)
            {
                return _serviceResponse.Fail("Student not found");
            }
            _mapper.Map(studentUpdateDTO, student);
            await _unitOfWork.SaveChangesAsync();
            var studentDTO = _mapper.Map<StudentDTO>(student);
            return _serviceResponse.Success(studentDTO);
        }
    }
}
