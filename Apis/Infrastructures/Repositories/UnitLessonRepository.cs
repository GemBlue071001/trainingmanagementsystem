using Application.Interfaces;
using Application.Repositories;
using Domain.Entities;

namespace Infrastructures.Repositories
{
    public class UnitLessonRepository : GenericRepository<UnitLesson>, IUnitLessonRepository
    {
        public UnitLessonRepository(AppDbContext applicationDbContext, ICurrentTime timeService, IClaimsService claimsService) : base(applicationDbContext, timeService, claimsService)
        {
        }
    }
}
