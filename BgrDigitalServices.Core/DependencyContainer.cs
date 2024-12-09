using Microsoft.Extensions.DependencyInjection;

namespace BgrDigitalServices.Core;

public static class DependencyContainer
{
    private static void AddDependencyMediatR(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining(typeof(AssemblyReference)));
    }
    public static void ConfigurarExtensionesCore(this IServiceCollection services)
    {
        services.AddDependencyMediatR();
    }
}