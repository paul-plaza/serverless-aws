namespace BgrDigital.Comun.EventBus
{
    public interface IEventBus
    {
        Task PublishTopic(string topic, string messageText);
    }
}