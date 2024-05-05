using Application.Utils;
using Application.ViewModels.Syllabus;
using Domain.Entities;
using Domain.Enums;
using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface ISyllabusService
    {
        Task<ServiceResponse> CreateSyllabusAsync(SyllabusCreateDTO createSyllabus);
        Task<ServiceResponse> UpdateSyllabusAsync(SyllabusUpdateDTO updateSyllabus);
        Task<ServiceResponse> RemoveSyllabusAsync(int id);
        Task<ServiceResponse> GetAverageOfStudentInSyllabusAsync(int idSyllabus, int idStudent);
        Task<ServiceResponse> GetAverageOfAllStudentInSyllabusAsync(int idSyllabus);
        Task<ServiceResponse> GetAllSyllabusAdvanceAsync(
            Expression<Func<Syllabus, bool>> filter = null,
            int pageSize = 0,
            int pageIndex = 1,
            SortType sortType = SortType.Ascending);
        Task<ServiceResponse> GetSyllabusByIdAsync(int id, int time);
    }
}
