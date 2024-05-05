using Application.Interfaces;
using Application.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructures.Repositories
{
    public class StudentAssignmentRepository : GenericRepository<StudentAssignment>, IStudentAssignmentRepository
    {
        public StudentAssignmentRepository(AppDbContext applicationDbContext, ICurrentTime timeService, IClaimsService claimsService) : base(applicationDbContext, timeService, claimsService)
        {

        }
        public async Task<ICollection<StudentAssignment>> GetStudentAssignmentByIdStudentAsync(Expression<Func<StudentAssignment, bool>>? filter = null
                                                          , bool tracked = true)
        {
            IQueryable<StudentAssignment> query = _db;
            if (!tracked)
            {
                query = query.AsNoTracking();
            }
            if (filter != null)
            {
                return await query.Where(filter).Include(c => c.Assignment).ToListAsync();
            }
            return await query.Include(c => c.Assignment).ToListAsync();
        }
    }
}
