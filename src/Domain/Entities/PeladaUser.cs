namespace Domain.Entities
{
    public class PeladaUser : BaseEntity
    {        
        public int PeladaId { get; set; }
        public Pelada Pelada { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
