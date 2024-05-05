using Domain.Entities;
using Domain.Enums;

namespace Application.ViewModels.TrainingProgramViewModels
{
    public class TrainingProgramUpdateDTO : BaseEntity
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public TrainingProgramStatus Status { get; set; }
        public ICollection<ProgramSyllabusUpdateDTO> ProgramSyllabuses { get; set; }
    }

    public class ProgramSyllabusUpdateDTO
    {
        public int SyllabusId { get; set; }
    }
}
