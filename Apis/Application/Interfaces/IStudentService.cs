using Application.Commons;
using Application.Utils;
using Application.ViewModels.Student;
using Application.ViewModels.TrainingProgramViewModels;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IStudentService
    {
        Task<Pagination<StudentDTO>> GetAllStudentInClass(
            int classId,
            int pageSize = 0,
            int pageIndex = 1,
            SortType sortType = SortType.Ascending);

        Task<ServiceResponse> GetStudentById(int id);
        Task<ServiceResponse> CreateStudent(StudentCreateDTO studentCreateDTO);
        Task<ServiceResponse> UpdateStudent(StudentUpdateDTO studentUpdateDTO);
        Task<ServiceResponse> SoftDeleteStudent(int id);
    }
}
