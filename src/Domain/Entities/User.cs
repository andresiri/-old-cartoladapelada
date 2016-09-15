using System.Collections.Generic;

namespace Domain.Entities
{
    public class User : BaseEntity
    {        
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public byte Number { get; set; }
        public string Position { get; set; }

        public List<Pelada> Peladas { get; set; }

        public void Validate()
        {
            
        }
    }
}
