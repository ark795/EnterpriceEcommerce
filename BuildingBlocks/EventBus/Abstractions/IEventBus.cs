using BuildingBlocks.EventBus.Events;

namespace BuildingBlocks.EventBus.Abstractions;

public interface IEventBus
{
    Task PublishAsync<T>(T @event) where T : IntegrationEvent;
    Task SubscribeAsync<T, THandler>()
        where T : IntegrationEvent
        where THandler : IIntegrationEventHandler<T>;
}
