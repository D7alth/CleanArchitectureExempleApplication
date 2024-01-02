using System.Reflection;
using CleanArch.App.Shared.Behavior;
using CleanArch.App.UseCases.CreateUser;
using CleanArch.App.UseCases.DeleteUser;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.App.Services
{
    public static class ServicesExtensions
    {
      public static void ConfigureApplicationApp(this IServiceCollection services)
      {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        services.AddScoped<IValidator<CreateUserRequest>, CreateUserValidator>();      
        services.AddScoped<IValidator<DeleteUserRequest>, DeleteUserValidator>();
      }
    }
}