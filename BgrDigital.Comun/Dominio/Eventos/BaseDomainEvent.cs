namespace BgrDigital.Comun.Dominio.Eventos
{
    public abstract class BaseDomainEvent(int userInSession, string nameSpace) : IDomainEvent
    {
        public MetaDataEvent Meta { get; } = new();
        public DateTimeOffset DateOccurred { get; protected set; } = DateTime.UtcNow;
        public string NameSpace { get; protected set; } = nameSpace;
        public int UserInSession { get; protected set; } = userInSession;
        public abstract string NameEvent { get; }
    }
}