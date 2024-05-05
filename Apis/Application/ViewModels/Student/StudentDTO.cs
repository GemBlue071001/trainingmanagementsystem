using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.Student
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Level { get; set; }
        public Gender Gender { get; set; }
        public UserStatus Status { get; set; }
        public UserRoleType Role { get; set; }
        public int TrainingClassId { get; set; }

    }
}
