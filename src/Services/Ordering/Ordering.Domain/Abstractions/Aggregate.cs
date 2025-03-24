

namespace Ordering.Domain.Abstractions
{
    public abstract class Aggregate<TId> : Entity<TId>, IAggregate<TId>
    {
        private readonly List<IDomainEvent> _domaineEvents = new();
        public IReadOnlyList<IDomainEvent> DomainEvents => _domaineEvents.AsReadOnly();
        public void AddDomainEvent(IDomainEvent domainEvents)
        {
            _domaineEvents.Add(domainEvents);
        }

        public IDomainEvent[] ClearDomainEvents()
        {
            IDomainEvent[] dequeuedEvents = _domaineEvents.ToArray();
            _domaineEvents.Clear();
            return dequeuedEvents;
        }
    }
}
