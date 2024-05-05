using Application.Interfaces;
using Application.Repositories;
using Domain.Entities;

namespace Infrastructures.Repositories
{
    public class UnitRepository : GenericRepository<Unit>, IUnitRepository
    {
        public UnitRepository(AppDbContext applicationDbContext, ICurrentTime timeService, IClaimsService claimsService) : base(applicationDbContext, timeService, claimsService)
        {
        }
    }
}
