using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.UnitClassDetailViewModel
{
    public class UnitClassDetailCreateDTO
    {
        public int UnitId { get; set; }
        public int TrainerId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int LocationId { get; set; }
        
    }
}
