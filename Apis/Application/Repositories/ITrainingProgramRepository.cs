using Domain.Entities;
using Domain.Enums;
using System.Linq.Expressions;

namespace Application.Repositories
{
    public interface ITrainingProgramRepository : IGenericRepository<TrainingProgram>
    {
        Task<TrainingProgram> GetTrainingProgramWithProgramSyllabusAsync(Expression<Func<TrainingProgram,
            bool>> filter = null, bool tracked = true);
        Task<List<TrainingProgram>> GetAllTrainingProgramsWithProgramSyllabusAsync<TKey>(Expression<Func<TrainingProgram, bool>> filter = null,
            int pageSize = 0,
            int pageIndex = 1,
            Expression<Func<TrainingProgram, TKey>> keySelectorForSort = null,
            SortType sortType = SortType.Ascending);
    }
}