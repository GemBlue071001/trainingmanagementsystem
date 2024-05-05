using Application.ViewModels.UnitClassLocationDTO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.UnitClassDetailViewModel
{
    public class UnitClassDetailViewDTO
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public UnitClassLocationViewDTO Location { get; set; }
    }
}
