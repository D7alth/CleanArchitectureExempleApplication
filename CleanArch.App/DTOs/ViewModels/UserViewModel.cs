using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.App.DTOs.ViewModels
{
    public class UserViewModel
    {
      public Guid Id { get; set; }
      public string? Name { get; set; }
      public string? Email { get; set; }
    }
}