using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Assignment : BaseEntity
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public AssignmentType Type { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int TrainingClassId { get; set; }
        public TrainingClass TrainingClass{ get; set; }

        public int SyllabusId { get; set; }
        public Syllabus Syllabus { get; set; }

        public ICollection<StudentAssignment> StudentAssignments { get; set; }
    }
}
