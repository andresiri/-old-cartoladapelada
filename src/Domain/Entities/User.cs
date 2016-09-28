using Domain.Entities.Validation;
using FluentValidation.Results;
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

        public List<PeladaUser> PeladaUsers { get; set; }
        public List<Pelada> Peladas { get; set; }

        public IList<ValidationFailure> Validate()
        {
            var validator = new UserValidation();
            var results = validator.Validate(this);
            
            var failures = results.Errors;
            return failures;
        }
    }
}
