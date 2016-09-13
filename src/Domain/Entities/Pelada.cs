namespace Domain.Entities
{
    public class Pelada
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public int CreatedByUserId { get; set; }
        public User User { get; set; }
    }
}
