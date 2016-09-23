using System.Collections.Generic;

namespace Domain.Entities
{
    public class Pelada : BaseEntity
    {        
        public string Description { get; set; }        
        public int CreatedByUserId { get; set; }

        public virtual User CreatedByUser { get; set; }
        public List<PeladaUser> PeladaUsers { get; set; }        
    }
}
