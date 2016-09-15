namespace Domain.Entities
{
    public class Pelada : BaseEntity
    {        
        public string Description { get; set; }

        public int CreatedByUserId { get; set; }
        public User User { get; set; }
    }
}
