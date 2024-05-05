namespace Domain.Entities
{
    public class ProgramSyllabus : BaseEntity
    {
        public int SyllabusId { get; set; }
        public Syllabus Syllabus { get; set; }
        public int TrainingProgramId { get; set; }
        public TrainingProgram TrainingProgram { get; set; }
    }
}
