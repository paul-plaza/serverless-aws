namespace BgrDigital.Comun.Dominio.Eventos
{
    public record MetaDataEvent
    {
        public string Host { get; } = Environment.MachineName;
        public string CorrelationId { get; } = Guid.NewGuid().ToString();
    }
}