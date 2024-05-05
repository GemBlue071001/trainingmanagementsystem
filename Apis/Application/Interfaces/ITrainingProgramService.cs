using Application.Utils;
using Application.ViewModels.TrainingProgramViewModels;
using Domain.Entities;
using Domain.Enums;
using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface ITrainingProgramService
    {
        Task<ServiceResponse> GetAllTrainingProgramAdvanceAsync(
            Expression<Func<TrainingProgram, bool>> filter = null,
            int pageSize = 0,
            int pageIndex = 1,
            SortType sortType = SortType.Ascending);
        Task<ServiceResponse> GetAllTrainingProgramsWithProgramSyllabusAdvanceAsync(
            Expression<Func<TrainingProgram, bool>> filter = null,
            int pageSize = 0,
            int pageIndex = 1,
            SortType sortType = SortType.Ascending);
        Task<ServiceResponse> GetTrainingProgramByIdAsync(int id);
        Task<ServiceResponse> CreateTrainingProgramAsync(TrainingProgramCreateDTO trainingProgramDTO);
        Task<ServiceResponse> DeleteTrainingProgramAsync(int id);
        Task<ServiceResponse> UpdateTrainingProgramAsync(TrainingProgramUpdateDTO trainingProgramDTO);
        Task<ServiceResponse> AddOneSyllabusToTrainingProgramAsync(int syllabusId, int trainingProgramId);
        Task<ServiceResponse> RemoveOneSyllabusToTrainingProgramAsync(int syllabusId, int trainingProgramId);

    }
}
