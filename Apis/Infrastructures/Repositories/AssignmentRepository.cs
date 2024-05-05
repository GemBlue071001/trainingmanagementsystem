using Application.Interfaces;
using Application.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructures.Repositories
{
    public class AssignmentRepository : GenericRepository<Assignment>, IAssignmentRepository
    {
        public AssignmentRepository(AppDbContext applicationDbContext, ICurrentTime timeService, IClaimsService claimsService) : base(applicationDbContext, timeService, claimsService)
        {
        }
    }
}
