using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.App.Interfaces;
using CleanArch.Infra.Context;

namespace CleanArch.Infra.Repository
{
  public class UnitOfWork(AppDbContext _context) : IUnitOfWork
  {
    private readonly AppDbContext Context = _context;

    public async Task Commit(CancellationToken cancellationToken)
    {
      await Context.SaveChangesAsync(cancellationToken);
    }
  }
}