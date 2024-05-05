using Application.Interfaces;
using Application.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructures.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext applicationDbContext, ICurrentTime timeService, IClaimsService claimsService) : base(applicationDbContext, timeService, claimsService)
        {
        }

        public async Task<bool> CheckUserNameExited(string username) => await _db.AnyAsync(u => u.UserName == username);
        public async Task<User> GetUserByUserNameAndPasswordHash(string username, string passwordHash)
        {
            return await _db.FirstOrDefaultAsync(record => record.UserName == username
                                        && record.Password == passwordHash);
        }

    }
}
