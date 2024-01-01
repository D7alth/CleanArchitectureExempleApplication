using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.App.Interfaces.Common;
using CleanArch.Domain.Common;
using CleanArch.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Repository
{
  public class BaseRepository<T>(AppDbContext _context) : IBaseRepository<T> where T : BaseEntity
  {
    protected readonly AppDbContext Context = _context;
    public void Create(T entity)
    {
      entity.DateCreated = DateTimeOffset.UtcNow;
      Context.Add(entity);
    }
    
    public void Update(T entity)
    {
      entity.DateUpdated = DateTimeOffset.UtcNow;
      Context.Update(entity);
    }

    public void Delete(T entity)
    {
      entity.DateDeleted = DateTimeOffset.UtcNow;
      Context.Remove(entity);
    }

    public async Task<T> Get(Guid id, CancellationToken cancellationToken)
    {
      return await Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task<List<T>> GetAll(CancellationToken cancellationToken)
    {
      return await Context.Set<T>().ToListAsync(cancellationToken);
    }

  }
}