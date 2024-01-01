using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.App.Interfaces;
using CleanArch.App.Interfaces.Users;
using CleanArch.Infra.Context;
using CleanArch.Infra.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistenceApp(this IServiceCollection services, string connectionString) 
        {
          services.AddDbContext<AppDbContext>(opt => opt.UseSqlite(connectionString));
          services.AddScoped<IUnitOfWork, UnitOfWork>();
          services.AddScoped<IUsersRepository, UserRepository>();
        }
    }
}