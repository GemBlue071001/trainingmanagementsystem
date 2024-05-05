using Domain.Entities;
using Domain.Enums;

namespace Application.ViewModels.TrainingProgramViewModels
{
    public class TrainingProgramCreateDTO
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public TrainingProgramStatus Status { get; set; }
        public ICollection<ProgramSyllabusCreateDTO> ProgramSyllabuses { get; set; }
    }

    public class ProgramSyllabusCreateDTO
    {
        public int SyllabusId { get; set; }
    }
}
