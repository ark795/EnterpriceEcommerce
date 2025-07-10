namespace BuildingBlocks.SharedKernel.Domain;

public abstract class BaseDomainEvent
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public DateTime OccurredOn { get; private set; } = DateTime.UtcNow;
}
