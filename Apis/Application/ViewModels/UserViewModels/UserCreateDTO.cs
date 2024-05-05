using Domain.Entities;
using Domain.Enums;

namespace Application.ViewModels.UserViewModels
{
    public class UserCreateDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Level { get; set; }
        public DateTime DoB { get; set; }
        public Gender Gender { get; set; }
        public int RoleId { get; set; }
        public UserRole? Role { get; set; }
    }
}