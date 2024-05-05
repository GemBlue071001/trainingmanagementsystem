using Application.ViewModels.UnitLesson;
using Domain.Entities;

namespace Application.ViewModels.Syllabus
{
    public class UnitViewDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Day { get; set; }
        public int SortOrder { get; set; }
        public ICollection<UnitLessonViewDTO> UnitLessons { get; set; }
    }
}
