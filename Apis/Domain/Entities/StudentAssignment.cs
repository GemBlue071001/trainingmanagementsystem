using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class StudentAssignment : BaseEntity
    {
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public decimal? Score { get; set; }
        public DateTime? TimeSubmit { get; set; }
        public bool? IsGraded { get; set; }
        public string? Comment { get; set; }
        public string? AssignmentFileLink { get; set; }
        public StudentAssignmentStatus Status { get; set; }
    }
}
