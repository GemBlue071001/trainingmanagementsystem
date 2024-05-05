using Domain.Enums;

namespace Domain.Entities
{
    public class TrainingClass : BaseEntity
    {
        public string ClassName { get; set; }
        public string ClassCode { get; set; } 
        public ClassLocation ClassLocation { get; set; }
        public DateTime ClassTimeStart { get; set; }//
        public DateTime ClassTimeEnd { get; set; }
        public ClassStatus Status { get; set; }//1
        public DateTime? ReviewedOn { get; set; }//1
        public int? UserReviewedId { get; set; }//1
        public DateTime? ApprovedOn { get; set; }//1
        public int? UserApprovedId { get; set; }//1


        public AttendeeType AttendeeType { get; set; }//

        public int NumberAttendeePlanned { get; set; }//
        public int NumberAttendeeAccepted { get; set; }//
        public int NumberAttendeeActual { get; set; }//

        public int FSUId { get; set; }
        public FSU FSU { get; set; }

        public int TrainingProgramId { get; set; }
        public TrainingProgram TrainingProgram { get; set; }
        public ICollection<ClassAdmin> Admins { get; set; }  //
        public ICollection<UnitClassDetail> UnitClassDetails { get; set; } //
        public ICollection<Student> Students { get; set; } // 
        public ICollection<Assignment> Assignments { get; set; }// 

    }
}
