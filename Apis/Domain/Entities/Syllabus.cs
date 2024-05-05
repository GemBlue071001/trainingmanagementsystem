using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Syllabus : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string TrainingDeliveryPrinciple { get; set; }
        public SyllabusLevel SyllabusLevel { get; set; }
        [Range(0, int.MaxValue)]    
        public int AttendeeNumber { get; set; }
        public string TechnicalRequirement { get; set; }
        public string CourseObjective { get; set; }
        [Range(0, int.MaxValue)]
        public float Version { get; set; }
        [Range(0, int.MaxValue)]    
        public int QuizSchema { get; set; }
        [Range(0, int.MaxValue)]    
        public int AssignmentSchema { get; set; }
        [Range(0, int.MaxValue)]    
        public int FinalSchema { get; set; }
        [Range(0, int.MaxValue)]    
        public int FinalTheorySchema { get; set; }
        [Range(0, int.MaxValue)]    
        public int FinalPracticeSchema { get; set; }
        [Range(0, int.MaxValue)]    
        public int GPASchema { get; set; }
        public ICollection<ProgramSyllabus> ProgramSyllabuses { get; set; }
        public ICollection<Unit> Units { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
    }
}