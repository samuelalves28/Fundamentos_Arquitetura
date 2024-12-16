using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace infrastructure.Base.Model;

public abstract class BaseModel
{
    /// <summary>
    /// É implementado a propriedade protected pois esses valores são gerados automaticamentes, e esses paramentros não pode mudar.
    /// </summary>
    protected BaseModel()
    {
        Id = Guid.NewGuid();
    }

    [BsonRepresentation(BsonType.String)]
    public Guid Id { get; set; }
}
