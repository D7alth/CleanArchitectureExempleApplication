using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Domain.Common
{
    public abstract class BaseEntity
    {
      public Guid Id { get; set; }
      public DateTimeOffset? DateCreated { get; set; }
      public DateTimeOffset? DateUpdated { get; set; }
      public DateTimeOffset? DateDeleted { get; set; }
    }
}