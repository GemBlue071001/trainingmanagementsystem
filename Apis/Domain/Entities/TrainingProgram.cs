using Domain.Enums;

namespace Domain.Entities
{
    public class TrainingProgram : BaseEntity
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public TrainingProgramStatus Status { get; set; }
        public TrainingClass TrainingClass { get; set; }
        public ICollection<ProgramSyllabus> ProgramSyllabuses { get; set; }
    }
}
