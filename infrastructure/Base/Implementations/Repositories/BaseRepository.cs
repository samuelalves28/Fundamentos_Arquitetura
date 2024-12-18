using infrastructure.Base.Implementations.Interfaces;
using infrastructure.Base.Model;
using infrastructure.Data;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace infrastructure.Base.Implementations.Repositories;

public abstract class BaseRepository<TModel> : IBaseRepository<TModel> where TModel : BaseModel
{
    public BaseRepository(IOptions<DataBaseSettings> DatabaseSettings)
    {
        var collectionName = nameof(TModel);
        var mongoClient = new MongoClient(DatabaseSettings.Value.ConnectionString)
            .GetDatabase(DatabaseSettings.Value.DatabaseName);

        _collection = mongoClient.GetCollection<TModel>(collectionName);
        Query = _collection.AsQueryable();
    }

    protected readonly IQueryable<TModel> Query;
    protected readonly IMongoCollection<TModel> _collection;

    public async Task<List<TModel>> GetAsync(CancellationToken cancellationToken)
        => await Query.ToListAsync(cancellationToken);

    public async Task<TModel?> GetAsync(Guid id, CancellationToken cancellationToken)
        => await Query.SingleAsync(w => w.Id == id, cancellationToken);

    public async Task CreateAsync(TModel newItem, CancellationToken cancellationToken)
        => await _collection.InsertOneAsync(newItem, cancellationToken: cancellationToken);

    public async Task UpdateAsync(Guid id, TModel updatedItem, CancellationToken cancellationToken)
        => await _collection.ReplaceOneAsync(w => w.Id == id, updatedItem, cancellationToken: cancellationToken);

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        => await _collection.DeleteOneAsync(w => w.Id == id, cancellationToken: cancellationToken);
}