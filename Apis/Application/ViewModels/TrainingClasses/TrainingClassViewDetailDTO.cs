using Application.ViewModels.FSUDTO;
using Application.ViewModels.TrainingProgramViewModels;
using Application.ViewModels.UnitClassDetailViewModel;
using Application.ViewModels.UserAdmin;
using Domain.Entities;
using Domain.Enums;
namespace Application.ViewModels.TrainingClasses
{
    public class TrainingClassViewDetailDTO
    {
        public string ClassName { get; set; }
        public string ClassCode { get; set; }
        public ClassLocation ClassLocation { get; set; }
        public DateTime ClassTimeStart { get; set; }
        public DateTime ClassTimeEnd { get; set; }
        public ClassStatus Status { get; set; }
        //public DateTime? ReviewedOn { get; set; }
        //public int? UserReviewedId { get; set; }
        //public DateTime? ApprovedOn { get; set; }
        //public int? UserApprovedId { get; set; }
        //public AttendeeType AttendeeType { get; set; }

        //public int NumberAttendeePlanned { get; set; }
        //public int NumberAttendeeAccepted { get; set; }
        //public int NumberAttendeeActual { get; set; }
        //public FSUViewDTO FSU { get; set; }
        public TrainingProgramViewOfClassDTO TrainingProgram { get; set; }

        //public ICollection<ClassAdminViewDTO> Admins { get; set; }
        //public ICollection<UnitClassDetailViewDTO> UnitClassDetails { get; set; }


    }
}
