
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.App.Interfaces.Common;
using CleanArch.Domain.Entities;

namespace CleanArch.App.Interfaces.Users
{
    public interface IUsersRepository : IBaseRepository<User>
    {
        Task<User> GetByEmail(string email, CancellationToken cancellationToken);
    }
}