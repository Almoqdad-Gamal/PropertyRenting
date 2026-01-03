using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using PropertyRenting.Application.Users.Commands;

namespace PropertyRenting.Application.Users.Validators
{
    public class RegisterUserCommandValidator : AbstractValidator<RegisterUserCommand>
    {
        public RegisterUserCommandValidator()
        {
            RuleFor(x => x.Dto.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Dto.Password).MinimumLength(6);
            RuleFor(x => x.Dto.FullName).NotEmpty();
        }
    }
}