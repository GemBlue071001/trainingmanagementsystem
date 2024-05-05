using Application.Interfaces;
using Application.Repositories;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Infrastructures.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly DbSet<T> _db;
        private readonly ICurrentTime _timeService;
        private readonly IClaimsService _claimsService;
        protected readonly AppDbContext _context;

        public GenericRepository(AppDbContext applicationDbContext, ICurrentTime timeService, IClaimsService claimsService)
        {
            _db = applicationDbContext.Set<T>();
            _timeService = timeService;
            _claimsService = claimsService;
            _context = applicationDbContext;
        }
        public async Task AddAsync(T entity)
        {
            entity.CreatedOn = _timeService.GetCurrentTime();
            entity.CreatedByUserId = _claimsService.GetCurrentUserId;
            await _db.AddAsync(entity);

        }
        public async Task RemoveAsync(T entity)
        {
            _db.Remove(entity);
        }
        public async Task UpdateAsync(T entity)
        {
            entity.ModifiedOn = _timeService.GetCurrentTime();
            entity.ModifiedByUserId = _claimsService.GetCurrentUserId;
            _db.Update(entity);
        }
        public async Task<T> GetAsync(Expression<Func<T, bool>>? filter = null, bool tracked = true)
        {
            IQueryable<T> query = _db;
            if (!tracked)
            {
                query = query.AsNoTracking();
            }
            if (filter != null)
            {
                return await query.FirstOrDefaultAsync(filter);
            }
            return await query.FirstOrDefaultAsync();
        }
        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null)
        {
            var query = _db.AsQueryable();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync();
        }
        public async Task AddRangeAsync(List<T> entities)
        {
            foreach (var entity in entities)
            {
                entity.CreatedOn = _timeService.GetCurrentTime();
                entity.CreatedByUserId = _claimsService.GetCurrentUserId;
            }
            await _db.AddRangeAsync(entities);
        }
        public async Task UpdateRangeAsync(List<T> entities)
        {
            foreach (var entity in entities)
            {
                entity.CreatedOn = _timeService.GetCurrentTime();
                entity.CreatedByUserId = _claimsService.GetCurrentUserId;
            }

            _db.UpdateRange(entities);
        }
        public async Task RemoveRangeAsync(List<T> entities)
        {
            _db.RemoveRange(entities);
        }
        public async Task<bool> AnyAsync(Expression<Func<T, bool>> filter)
        {
            return await _db.AnyAsync(filter);
        }

        public async Task<List<T>> GetAllAdvanceAsync<TKey>(Expression<Func<T, bool>> filter = null,
                                                        int pageSize = 0,
                                                        int pageIndex = 1,
                                                        Expression<Func<T, TKey>> keySelectorForSort = null,
                                                        SortType sortType = SortType.Ascending)
        {
            var query = _db.AsQueryable();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (keySelectorForSort != null)
            {
                switch (sortType)
                {
                    case SortType.Ascending:
                        query = query.OrderBy(keySelectorForSort);
                        break;
                    case SortType.Descending:
                        query = query.OrderByDescending(keySelectorForSort);
                        break;
                    default:
                        break;
                }
            }

            if (pageSize > 0 && pageIndex > 0)
            {
                return await query
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
            }

            return await query.ToListAsync();
        }

        public async Task<int> CountNumberOfElement(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = _db;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.CountAsync();
        }
    }
}