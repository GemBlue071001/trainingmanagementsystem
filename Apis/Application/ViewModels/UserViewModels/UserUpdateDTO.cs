using Domain.Enums;

namespace Application.ViewModels.UserViewModels
{
    public class UserUpdateDTO
    {
        public string? Level { get; set; }
        public UserStatus? Status { get; set; }
        public UserRoleType? Role { get; set; }
    }
}
