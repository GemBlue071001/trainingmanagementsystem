using Application.ViewModels.UnitLesson;
using Domain.Entities;
using Domain.Enums;

namespace Application.ViewModels.Syllabus
{
    public class SyllabusCreateDTO
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string TrainingDeliveryPrinciple { get; set; }
        public SyllabusLevel SyllabusLevel { get; set; }
        public int AttendeeNumber { get; set; }
        public string TechnicalRequirement { get; set; }
        public string CourseObjective { get; set; }
        public float Version { get; set; }
        public int QuizSchema { get; set; }
        public int AsignmentSchema { get; set; }
        public int FinalSchema { get; set; }
        public int FinalTheorySchema { get; set; }
        public int FinalPraticeSchema { get; set; }
        public int GPASchema { get; set; }
        public ICollection<UnitCreateDTO> Units { get; set; }
     
    }
}
