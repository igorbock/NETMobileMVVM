using Ninject.Modules;
using VisualBasicLib;

namespace MauiCRUD.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddNinjectModules(this IServiceCollection services, NinjectModule[] modules)
    {
        var kernel = NinjectConfig.CreateKernel(modules);
        var bindings = NinjectConfig.GetBinds();
        foreach (var binding in bindings)
        {
            var serviceType = binding.Service;
            Func<IServiceProvider, object> implementation = provider => kernel.GetService(serviceType)!;

            var serviceName = kernel.GetService(serviceType)?.GetType().Name ?? implementation.Method.Name;

            services.AddScoped(serviceType, implementation);
        }
    }
}
