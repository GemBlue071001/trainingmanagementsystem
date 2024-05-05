using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Student : User
    {
        public int TrainingClassId { get; set; }
        public TrainingClass TrainingClass { get; set; }
        public ICollection<StudentAssignment> StudentAssignments { get; set; }

    }
}
