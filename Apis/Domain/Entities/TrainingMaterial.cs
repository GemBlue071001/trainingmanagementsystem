namespace Domain.Entities
{
    public class TrainingMaterial : BaseEntity
    {
        public string FileName { get; set; }
        public string FileLink { get; set; }
        public int UnitLessonId { get; set; }
        public UnitLesson UnitLesson { get; set; }
    }
}
