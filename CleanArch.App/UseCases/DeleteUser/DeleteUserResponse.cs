using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.App.UseCases.DeleteUser
{
    public class DeleteUserResponse
    {
      public Guid Id { get; set; }
      public string? Email { get; set; }
      public string? Name { get; set; }
      public DateTimeOffset? DateDeleted { get; set; }   
    }
}