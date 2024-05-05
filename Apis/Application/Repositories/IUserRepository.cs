using Domain.Entities;

namespace Application.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<bool> CheckUserNameExited(string username);
        Task<User> GetUserByUserNameAndPasswordHash(string username, string passwordHash);
    }
}
