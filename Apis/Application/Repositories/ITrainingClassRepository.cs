using Domain.Entities;

namespace Application.Repositories
{
    public interface ITrainingClassRepository : IGenericRepository<TrainingClass>
    {
        Task<int> CountTrainingClass(int pageIndex,
            int pageSize,
            string search,
            DateTime createOnStart = default,
            DateTime createOnEnd = default);
        Task<List<TrainingClass>> GetTrainingClassPaging(int pageIndex,
            int pageSize,
            string search,
            DateTime createOnStart = default,
            DateTime createOnEnd = default);

        Task<TrainingClass> GetTrainingClassDetail(int id);
        Task<TrainingClass?> GetTrainingClassWithCloseRelation(int id);
        Task<int> CountAllTrainingClassAsync();
    }
}