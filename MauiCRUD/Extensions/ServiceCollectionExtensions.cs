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
            services.AddScoped(serviceType, provider => kernel.GetService(serviceType)!);
        }
    }
}
