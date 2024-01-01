using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domain.Common;

namespace CleanArch.Domain.Entities
{
    public class User(string email, string name) : BaseEntity
    {
        public string? Email { get; set; } = email;
        public string? Name { get; set; } = name;
  }
}