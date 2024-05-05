using Domain.Enums;

namespace Domain.Entities
{
    public class UserRole : BaseEntity
    {
        public UserRoleType RoleType { get; set; }
        public UserRoleAccessPermission SyllabusAccessPermission { get; set; }
        public UserRoleAccessPermission TrainingProgramAccessPermission { get; set; }
        public UserRoleAccessPermission ClassAccessPermission { get; set; }
        public UserRoleAccessPermission LearningMaterialAccessPermission { get; set; }
        public UserRoleAccessPermission UserAccessPermission { get; set; }
        
    }
}