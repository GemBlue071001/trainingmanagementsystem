namespace Domain.Entities
{
    public class Unit : BaseEntity
    {
        public string Name { get; set; }
        public int Day { get; set; }
        public int SortOrder { get; set; }
        public int SyllabusId { get; set; }
        public Syllabus Syllabus { get; set; }
        public ICollection<UnitLesson> UnitLessons { get; set; }
        public ICollection<UnitClassDetail> UnitClassDetails { get; set; }
    }
}