using Application.Interfaces;
using Application.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructures.Repositories
{
    public class SyllabusRepository : GenericRepository<Syllabus>, ISyllabusRepository
    {
        public SyllabusRepository(AppDbContext applicationDbContext, ICurrentTime timeService, IClaimsService claimsService) : base(applicationDbContext, timeService, claimsService)
        {
        }
        public async Task<Syllabus> GetSyllabusRelationUnitAsync(int id)=> await _db
                                                                            .Include(s => s.Units)
                                                                                .ThenInclude(u => u.UnitLessons)
                                                                                    .ThenInclude(ul => ul.OutputStandard)
                                                                            .Include(s => s.Units)
                                                                                .ThenInclude(u => u.UnitLessons)
                                                                                    .ThenInclude(ul => ul.TrainingMaterials)
                                                                            .FirstOrDefaultAsync(s => s.Id == id);


        public async Task<Syllabus> GetSyllabusByIdAsync(Expression<Func<Syllabus, bool>>? filter = null
                                                            , bool tracked = true)
        {
            IQueryable<Syllabus> query = _db;
            if (!tracked)
            {
                query = query.AsNoTracking();
            }
            if (filter != null)
            {
                return await query.Include(c => c.Units).ThenInclude(u => u.UnitLessons).FirstOrDefaultAsync(filter);

            }
            return await query.Include(c => c.Units).ThenInclude(u => u.UnitLessons).FirstOrDefaultAsync();
        }

        public async Task<Syllabus> GetSyllabusRelationAssignmentAsync(int id) => await _db.Where(x=>x.Id == id)
                                                                                        .Include(c => c.Assignments)
                                                                                        .ThenInclude(u => u.StudentAssignments).FirstOrDefaultAsync();
/*        public async Task<bool> GetSyllabusRelationAssignmentJoinAsync(int id)
        {
            _context.StudentAssignments
                     .Join(_context.Assignments, sa => sa.AssignmentId, a => a.Id, (sa, a) => new { sa, a })
                     .Join(_context.Syllabuses, s => s.a.SyllabusId, syll => syll.Id, (s, syll) => new { s.sa, s.a, syll })
                     .Where(s => s.sa.Score.HasValue && s.a.Type != AssignmentType.Quiz)
                     .GroupBy(s => s.sa.StudentId)
                     .Select(g => new {
                         StudentId = g.Key,
                         TotalScore = g.Sum(s => (decimal)s.sa.Score * (decimal)s.a.Type.GetPercentageFromSyllabus(s.syll)),
                         TotalWeight = g.Sum(s => (decimal)s.a.Type.GetPercentageFromSyllabus(s.syll)),
                     })
                     .Where(g => g.TotalWeight > 0)
                     .Select(g => new {
                         g.StudentId,
                         AverageGpa = g.TotalScore / g.TotalWeight
                     })
                     .ToList();
            //var get = query.Where(c => c.Id == id).SelectMany(s => s.Assignments.SelectMany(u => u.StudentAssignments)).Select(x => new
            //{
            //    k = sbyte
            //});
            return value;
        }*/
    }
}
