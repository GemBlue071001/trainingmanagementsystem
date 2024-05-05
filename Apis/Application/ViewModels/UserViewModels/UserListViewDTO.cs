using Domain.Enums;

namespace Application.ViewModels.UserViewModels
{
    public class UserListViewDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DoB { get; set; }
        public string Level { get; set; }
        public Gender Gender { get; set; }
        public UserStatus Status { get; set; }
        public UserRoleType Role { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedByUserId { get; set; }
    }
}
