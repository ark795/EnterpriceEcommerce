using BuildingBlocks.SharedKernel.Domain;

namespace BuildingBlocks.SharedKernel.DDD;

public interface IRepository<T> where T : IAggregateRoot
{
    Task<T?> GetByIdAsync(Guid id);
    Task AddAsync(T entity);
    Task DeleteAsync(T entity);
    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}
