using Application.Interfaces;
using Application.Repositories;
using Domain.Entities;

namespace Infrastructures.Repositories
{
    public class TrainingMaterialRepository : GenericRepository<TrainingMaterial>, ITrainingMaterialRepository
    {
        public TrainingMaterialRepository(AppDbContext applicationDbContext, ICurrentTime timeService, IClaimsService claimsService) : base(applicationDbContext, timeService, claimsService)
        {
        }
    }
}