using Application.ViewModels.UnitLesson;
using Domain.Entities;

namespace Application.ViewModels.Syllabus
{
    public class UnitCreateDTO
    {
        public string Name { get; set; }
        public int Day { get; set; }
        public int SortOrder { get; set; }
        public ICollection<UnitLessonCreateDTO> UnitLessons { get; set; }
    
    }
}
