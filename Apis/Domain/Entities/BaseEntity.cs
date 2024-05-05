namespace Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedByUserId { get; set; }
        // TODO
        //public User? CreatedByUser { get; set; } 
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedByUserId { get; set; }
        //TODO
        //public User? ModifiedByUser { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
