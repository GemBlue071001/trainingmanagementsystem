using Application.Interfaces;
using Application.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructures.Repositories
{
    public class TrainingClassRepository : GenericRepository<TrainingClass>, ITrainingClassRepository
    {
        public TrainingClassRepository(AppDbContext applicationDbContext, ICurrentTime timeService, IClaimsService claimsService) : base(applicationDbContext, timeService, claimsService)
        {
        }

        public async Task<List<TrainingClass>> GetTrainingClassPaging(int pageIndex,
            int pageSize,
            string search, DateTime
            createOnStart,
            DateTime createOnEnd)
        {
            IQueryable<TrainingClass> query = _db;
            if (!string.IsNullOrEmpty(search))
                query = query.Where(b => b.ClassName.Contains(search) || b.ClassCode.Contains(search));
            if (createOnStart != default)
                query = query.Where(a => a.CreatedOn > createOnStart);
            if (createOnEnd != default)
                query = query.Where(a => a.CreatedOn < createOnEnd);
            return await query
          .Where(b => !b.IsDeleted)
          .Skip((pageIndex - 1) * pageSize)
          .Take(pageSize)
          .ToListAsync();
        }

        public async Task<int> CountTrainingClass(int pageIndex,
            int pageSize,
            string search,
            DateTime createOnStart,
            DateTime createOnEnd)
        {
            IQueryable<TrainingClass> query = _db;
            if (!string.IsNullOrEmpty(search))
                query = query.Where(b => b.ClassName.Contains(search) || b.ClassCode.Contains(search));
            if (createOnStart != default)
                query = query.Where(a => a.CreatedOn > createOnStart);
            if (createOnEnd != default)
                query = query.Where(a => a.CreatedOn < createOnEnd);
            return await query
          .Where(b => b.IsDeleted == false)
          .CountAsync();
        }

        public async Task<int> CountAllTrainingClassAsync()
        {
            IQueryable<TrainingClass> query = _db;
            return await query
          .Where(b => b.IsDeleted == false)
          .CountAsync();
        }


        public async Task<TrainingClass> GetTrainingClassDetail(int id)
        {
            IQueryable<TrainingClass> query = _db;
            var _class = await _db
                .Include(c => c.TrainingProgram)
                    .ThenInclude(c => c.ProgramSyllabuses)
                    .ThenInclude(sp => sp.Syllabus)
                    .ThenInclude(s => s.Units)
                    .ThenInclude(u => u.UnitClassDetails)
                    .ThenInclude(a => a.Location)
               .Include(c => c.TrainingProgram)
                    .ThenInclude(c => c.ProgramSyllabuses)
                    .ThenInclude(sp => sp.Syllabus)
                    .ThenInclude(s => s.Units)
                    .ThenInclude(a => a.UnitLessons)
               .Include(a => a.Admins)
                    .ThenInclude(a => a.User)
               .FirstOrDefaultAsync(a => a.Id == id);
            return _class;
        }

        public async Task<TrainingClass?> GetTrainingClassWithCloseRelation(int id)
        {
            var _class = await _db
                                  .Include(c => c.UnitClassDetails)
                                  .Include(c => c.Assignments)
                                  .Include(c => c.Admins)
                                  .Include(c => c.TrainingProgram)
                                  .Include(c => c.Students)
                                  .FirstOrDefaultAsync(c => c.Id == id);
            return _class;
        }

    }
}