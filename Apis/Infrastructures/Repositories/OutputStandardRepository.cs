using Application.Interfaces;
using Application.Repositories;
using Domain.Entities;

namespace Infrastructures.Repositories
{
    public class OutputStandardRepository : GenericRepository<OutputStandard>, IOutputStandardRepository
    {
        public OutputStandardRepository(AppDbContext applicationDbContext, ICurrentTime timeService, IClaimsService claimsService) : base(applicationDbContext, timeService, claimsService)
        {
        }
    }
}
