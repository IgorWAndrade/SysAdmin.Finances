using Microsoft.Extensions.DependencyInjection;
using Module.Identity.Application.UseCases;
using Module.Identity.Core.Entities;
using Module.Identity.Core.Repositories;
using Module.Identity.Core.Services;
using Module.Identity.Core.UseCases;
using Module.Identity.Infraestructure.Data;
using Module.Identity.Service;

namespace Module.Identity.Infraestructure.CrossCutting;
public static class NativeInjectorBootStrapper
{
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<ICreateUserUseCase, CreateUserCaseUse>();
    }
}
