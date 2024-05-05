using Application.ViewModels.Syllabus;

namespace Application.ViewModels.TrainingProgramViewModels
{
    public class ProgramSyllabusDTO
    {
        public ClassProgramSylabusViewDTO Syllabus { get; set; }
    }

    public class ClassProgramSylabusViewDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Duration { get; set; }
        public ICollection<UnitViewDTO> Units { get; set; }
    }

}
