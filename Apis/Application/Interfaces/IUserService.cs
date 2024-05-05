using Application.Utils;
using Application.ViewModels.UserViewModels;

namespace Application.Interfaces
{
    public interface IUserService
    {
        Task<ServiceResponse> CreateUserAsync(UserCreateDTO userCreate);
        Task<ServiceResponse> LoginAsync(UserLoginDTO userDTO);
        Task<ServiceResponse> GetAllUsersAsync();
        Task<ServiceResponse> UpdateUserAsync(int id, UserUpdateDTO userUpdate);
        Task<ServiceResponse> GetUserByIdAsync(int id);
        Task<ServiceResponse> UpdateMeAsync(int id, UserUpdateMeDTO userUpdate);
    }
}
