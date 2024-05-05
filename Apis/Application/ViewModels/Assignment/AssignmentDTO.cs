
using Domain.Entities;

namespace Application.ViewModels.Assignment
{
    public class AssignmentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public AssignmentType Type { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int TrainingClassId { get; set; }
        public TrainingClass TrainingClass { get; set; }

        public int SyllabusId { get; set; }
        public Domain.Entities.Syllabus Syllabus { get; set; }

        public ICollection<StudentAssignment> StudentAssignments { get; set; }
    }
}
