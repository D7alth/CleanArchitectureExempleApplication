using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CleanArch.App.UseCases.CreateUser
{   
    /*
      Represent the command for creating a new user and contains the parameters for creating user
      like a InputModel (DTOs), using the MediatR interface (IRequest) appoint the entity CreateUserResponse

      using record because it is immutable
    */
    public sealed record CreateUserRequest(string Email, string Name) : IRequest<CreateUserResponse>
    {
        
    }
}