using Amazon.Lambda.Core;
using Amazon.Lambda.SQSEvents;
using BgrDigitalServices.VerificacionDatos.Extensiones;
using Microsoft.Extensions.DependencyInjection;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace BgrDigitalServices.VerificacionDatos;

public class Function
{
    public async Task FunctionHandler(SQSEvent evnt, ILambdaContext context)
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.ConfigureServices();

        // create service provider
        var serviceProvider = serviceCollection.BuildServiceProvider();

        // entry to run app.
        await serviceProvider.GetService<App>()?.Run(evnt, context)!;

    }


}