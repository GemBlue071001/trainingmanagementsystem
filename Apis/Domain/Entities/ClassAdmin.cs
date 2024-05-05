namespace Domain.Entities
{
    public class ClassAdmin : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int TrainingClassId { get; set; }
        public TrainingClass TrainingClass { get; set; }
    }
}