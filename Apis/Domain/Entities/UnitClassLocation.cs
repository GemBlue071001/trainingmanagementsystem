using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UnitClassLocation : BaseEntity
    {
        public string BuildingLocation { get; set; }
        public ClassLocation City { get; set; }
        public string Room { get; set; }
        public ICollection<UnitClassDetail> UnitClassDetailLocations { get; set; }
    }
}
