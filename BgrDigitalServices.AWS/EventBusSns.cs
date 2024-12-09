using System;
using System.Threading.Tasks;
using Amazon.Internal;
using Amazon.Runtime.Endpoints;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using BgrDigital.Comun.EventBus;

namespace BgrDigitalServices.AWS
{
    public class EventBusSns : IEventBus
    {

        public async Task PublishTopic(string topic, string messageText)
        {
            string topicArn = "arn:aws:sns:us-east-2:019019187573:verifica-datos-usuario-topic";

            IAmazonSimpleNotificationService client = new AmazonSimpleNotificationServiceClient(new AmazonSimpleNotificationServiceConfig()
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast2,
                EndpointProvider = new StaticEndpointProvider("sns.us-east-2.amazonaws.com")
            });


            var request = new PublishRequest
            {
                TopicArn = topicArn,
                Message = messageText,

            };

            try
            {
                var response = await client.PublishAsync(request);
                Console.WriteLine($"Successfully published message ID: {response.MessageId}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }


        }
    }
}