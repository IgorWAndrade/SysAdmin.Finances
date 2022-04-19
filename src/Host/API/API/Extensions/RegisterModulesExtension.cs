using Microsoft.Extensions.DependencyInjection;
using System;

namespace API.Extensions
{
    public static class RegisterModulesExtension
    {
        public static void Services(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            Module.Customer.Infraestructure.CrossCutting.NativeInjectorBootStrapper.RegisterServices(services);
            Module.Identity.Infraestructure.CrossCutting.NativeInjectorBootStrapper.RegisterServices(services);
            Module.Finances.Infraestructure.CrossCutting.NativeInjectorBootStrapper.RegisterServices(services);
            Module.Shared.NativeInjectorBootStrapper.RegisterServices(services);
            Module.Report.NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
