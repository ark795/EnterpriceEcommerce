namespace BuildingBlocks.EventBus.Events;

public interface IIntegrationEventHandler<in T> where T : IntegrationEvent
{
    Task HandleAsync(T @event, CancellationToken cancellationToken = default);
}
