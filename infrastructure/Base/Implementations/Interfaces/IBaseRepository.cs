namespace infrastructure.Base.Implementations.Interfaces;

public interface IBaseRepository<TModel>
{
    Task<List<TModel>> GetAsync(CancellationToken cancellationToken);
    Task<TModel?> GetAsync(Guid id, CancellationToken cancellationToken);
    Task CreateAsync(TModel newItem, CancellationToken cancellationToken);
    Task UpdateAsync(Guid id, TModel updatedItem, CancellationToken cancellationToken);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}
