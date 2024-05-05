using Domain.Entities;
using Domain.Enums;

namespace Application.ViewModels.TrainingProgramViewModels
{
    public class TrainingProgramViewDTO : BaseEntity
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public TrainingProgramStatus Status { get; set; }
        public TrainingClass TrainingClass { get; set; }
        public ICollection<ProgramSyllabusDTO> ProgramSyllabuses { get; set; }
    }
}
