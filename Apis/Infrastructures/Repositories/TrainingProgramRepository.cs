using Application.Interfaces;
using Application.Repositories;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructures.Repositories
{
    public class TrainingProgramRepository : GenericRepository<TrainingProgram>, ITrainingProgramRepository
    {
        public TrainingProgramRepository(AppDbContext applicationDbContext, ICurrentTime timeService, IClaimsService claimsService) : base(applicationDbContext, timeService, claimsService)
        {
        }

        public async Task<List<TrainingProgram>> GetAllTrainingProgramsWithProgramSyllabusAsync<TKey>(Expression<Func<TrainingProgram, bool>> filter = null, int pageSize = 0, int pageIndex = 1, Expression<Func<TrainingProgram, TKey>> keySelectorForSort = null, SortType sortType = SortType.Ascending)
        {
            var query = _db.AsQueryable();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            query = query.Include(x => x.ProgramSyllabuses).ThenInclude(x => x.Syllabus);
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

        public async Task<TrainingProgram> GetTrainingProgramWithProgramSyllabusAsync
            (Expression<Func<TrainingProgram, bool>> filter = null, 
            bool tracked = true)
        {
            IQueryable<TrainingProgram> query = _db;
            if (!tracked) 
            {
                query = query.AsNoTracking();
            }
            if (filter != null)
            {
                return await query.Include(c => c.ProgramSyllabuses).ThenInclude(x => x.Syllabus).FirstOrDefaultAsync(filter);
            }
            return await query.Include(c => c.ProgramSyllabuses).ThenInclude(x => x.Syllabus).FirstOrDefaultAsync();
        }
    }
}