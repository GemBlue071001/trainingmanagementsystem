using Domain.Enums;

namespace Application.ViewModels.UserViewModels
{
    public class UserUpdateMeDTO
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Gender? Gender { get; set; }
    }
}
