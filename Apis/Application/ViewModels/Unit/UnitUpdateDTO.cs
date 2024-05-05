using Application.ViewModels.UnitLesson;
using Domain.Entities;

namespace Application.ViewModels.Syllabus
{
    public class UnitUpdateDTO
    {
        public int? Id { get; set; }

        public string Name { get; set; }
        public int Day { get; set; }
        public int SortOrder { get; set; }
        public ICollection<UnitLessonUpdateDTO> UnitLessons { get; set; }
    }
}
