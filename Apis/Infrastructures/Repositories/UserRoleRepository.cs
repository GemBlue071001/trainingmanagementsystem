using Application.Interfaces;
using Application.Repositories;
using Domain.Entities;

namespace Infrastructures.Repositories
{
    public class UserRoleRepository : GenericRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(AppDbContext applicationDbContext, ICurrentTime timeService, IClaimsService claimsService) : base(applicationDbContext, timeService, claimsService)
        {
        }
    }
}