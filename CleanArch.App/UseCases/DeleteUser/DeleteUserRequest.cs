using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CleanArch.App.UseCases.DeleteUser
{
    public sealed record DeleteUserRequest(Guid Id) : IRequest<DeleteUserResponse>
    {
        
    }
}