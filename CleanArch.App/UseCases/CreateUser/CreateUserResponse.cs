using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.App.UseCases.CreateUser
{   
    /*
      CreateUserResponse, represent the response before creating a user and
      contains critical information about the user that was created
      like Id, Email and Name.
    */
    public sealed record CreateUserResponse
    {
        public Guid Id { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
    }
}