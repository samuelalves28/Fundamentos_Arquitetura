using infrastructure.Base.Implementations.Interfaces;
using infrastructure.Base.Model;
using infrastructure.Data;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace infrastructure.Base.Implementations.Repositories;

public abstract class BaseRepository<TModel> : IBaseRepository<TModel> where TModel : BaseModel
{
    public BaseRepository(IOptions<DataBaseSettings> DatabaseSettings)
    {
        var mongoClient = new MongoClient(DatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(DatabaseSettings.Value.DatabaseName);
        var CollectionName = typeof(TModel).Name;

        Query = mongoDatabase.GetCollection<TModel>(CollectionName);
    }

    public readonly IMongoCollection<TModel> Query;

    public async Task<List<TModel>> GetAsync() => await Query.Find(w => true).ToListAsync();

    public async Task<TModel?> GetAsync(Guid id) => await Query.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(TModel newItem) => await Query.InsertOneAsync(newItem);

    public async Task UpdateAsync(Guid id, TModel updatedItem) => await Query.ReplaceOneAsync(x => x.Id == id, updatedItem);

    public async Task DeleteAsync(Guid id) => await Query.DeleteOneAsync(x => x.Id == id);
}