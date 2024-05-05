using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.TrainingClasses
{
    public class TrainingClassInfomationUpdateDTO
    {
        public int TrainingClassId { get; set; }
        public DateTime ClassTimeStart { get; set; }
        public DateTime ClassTimeEnd { get; set; }
        public AttendeeType AttendeeType { get; set; }
        public int NumberAttendeePlanned { get; set; }
        public int NumberAttendeeAccepted { get; set; }
        public int NumberAttendeeActual { get; set; }
    }
}
