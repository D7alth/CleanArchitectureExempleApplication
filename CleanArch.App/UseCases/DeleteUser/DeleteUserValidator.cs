using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace CleanArch.App.UseCases.DeleteUser
{
    public class DeleteUserValidator : AbstractValidator<DeleteUserRequest>
    {
        public DeleteUserValidator()
        {
          RuleFor(x => x.Id).NotEmpty();
        }
    }
}