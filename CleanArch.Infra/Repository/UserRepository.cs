using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.App.Interfaces.Users;
using CleanArch.Domain.Entities;
using CleanArch.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Repository
{
  public class UserRepository(AppDbContext _context) : BaseRepository<User>(_context), IUsersRepository
  {
    public async Task<User> GetByEmail(string email, CancellationToken cancellationToken)
    {
      return await Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
    }
  }
}