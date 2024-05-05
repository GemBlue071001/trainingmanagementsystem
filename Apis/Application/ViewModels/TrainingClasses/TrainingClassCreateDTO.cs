using Application.ViewModels.ClassAdminDTO;
using Application.ViewModels.UnitClassDetailViewModel;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.TrainingClasses
{
    public class TrainingClassCreateDTO
    {
        public string ClassName { get; set; }
        //public string ClassCode { get; set; }
        public ClassLocation ClassLocation { get; set; }
        public DateTime ClassTimeStart { get; set; }
        public DateTime ClassTimeEnd { get; set; }
        public ClassStatus Status { get; set; }
        public AttendeeType AttendeeType { get; set; }

        public int NumberAttendeePlanned { get; set; }
        public int NumberAttendeeAccepted { get; set; }
        public int NumberAttendeeActual { get; set; }

        public int FSUId { get; set; }
        public int TrainingProgramId { get; set; }
        public ICollection<ClassAdminCreateDTO> Admins { get; set; }
        public ICollection<UnitClassDetailCreateDTO> UnitClassDetails { get; set; }
    }
}
