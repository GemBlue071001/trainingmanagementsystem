using Domain.Entities;
using Domain.Enums;
using System.Linq.Expressions;

namespace Application.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetAsync(Expression<Func<T, bool>> filter = null, bool tracked = true);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);
        Task AddAsync(T entity);
        Task AddRangeAsync(List<T> entities);
        Task UpdateRangeAsync(List<T> entities);
        Task RemoveRangeAsync(List<T> entities);
        Task RemoveAsync(T entity);
        Task UpdateAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> filter);
        Task<List<T>> GetAllAdvanceAsync<TKey>(
            Expression<Func<T, bool>> filter = null,
            int pageSize = 0,
            int pageIndex = 1,
            Expression<Func<T, TKey>> keySelectorForSort = null,
            SortType sortType = SortType.Ascending);
        Task<int> CountNumberOfElement(Expression<Func<T, bool>> filter = null);
    }
}