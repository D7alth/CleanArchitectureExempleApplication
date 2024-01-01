using System.Reflection;
using CleanArch.App.UseCases.CreateUser;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.App.Services
{
    public static class ServicesExtensions
    {
      public static void ConfigureApplicationApp(this IServiceCollection services)
      {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        services.AddScoped<IValidator<CreateUserRequest>, CreateUserValidator>();      }
    }
}