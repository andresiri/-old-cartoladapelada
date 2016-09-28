using FluentValidation;

namespace Domain.Entities.Validation
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(user => user.Email).NotEmpty().EmailAddress();
            RuleFor(user => user.Password).NotEmpty();
            RuleFor(user => user.FirstName).NotEmpty();
            RuleFor(user => user.LastName).NotEmpty();
        }
    }
}
