using BgrDigitalServices.Core;
using Microsoft.Extensions.DependencyInjection;

namespace BgrDigitalServices.VerificacionDatos.Extensiones
{
    public static class ExtensionsServices
    {
        public static void ConfigureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.ConfigurarExtensionesCore();
            serviceCollection.AddTransient<App>();
        }
    }
}