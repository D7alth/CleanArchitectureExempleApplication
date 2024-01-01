using Microsoft.EntityFrameworkCore;
using CleanArch.Domain.Entities;

namespace CleanArch.Infra.Context
{
    public class AppDbContext : DbContext
    {

    public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
    {}
    public DbSet<User> Users { get; set; }
    }

}