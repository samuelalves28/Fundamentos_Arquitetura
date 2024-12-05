using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace infrastructure.Base.Model;

public class BaseModel
{
    protected BaseModel()
    {
        Id = Guid.NewGuid();
    }

    [BsonRepresentation(BsonType.String)]
    public Guid Id { get; set; }
}
