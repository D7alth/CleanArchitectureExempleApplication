using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Internal;

namespace CleanArch.App.UseCases.CreateUser
{
    public sealed class CreateUserValidator : AbstractValidator<CreateUserRequest>
    {
       public CreateUserValidator()
       {
        RuleFor(x => x.Email).NotEmpty().MaximumLength(100).EmailAddress();
        RuleFor(x => x.Name).NotEmpty().MaximumLength(100).MinimumLength(3);
       }
    }
}       