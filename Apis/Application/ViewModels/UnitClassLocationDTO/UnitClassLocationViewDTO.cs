using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.UnitClassLocationDTO
{
    public class UnitClassLocationViewDTO
    {
        public string BuildingLocation { get; set; }
        public ClassLocation City { get; set; }
        public string Room { get; set; }
    }
}
