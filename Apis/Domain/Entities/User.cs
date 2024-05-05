using Domain.Enums;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string UserName  { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Level { get; set; }
        public Gender Gender { get; set; }
        public UserStatus Status { get; set; }
        public UserRoleType Role { get; set; }
        //config for classAdmin
        public ICollection<ClassAdmin> ClassAdmins { get; set; }

        //config for UnitClassDetail
        public ICollection<UnitClassDetail> UnitClassDetails { get; set; }
    }
}