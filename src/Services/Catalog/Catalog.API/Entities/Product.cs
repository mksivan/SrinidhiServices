using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.API.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("Name")]
        public string? Name { get; set; }
        public string? Category { get; set; }
        public string Summary { get; set; } = string.Empty ;
        public string Description { get; set; } = string.Empty;
        public string? ImageFile { get; set; }
        public decimal Price { get; set; } = 0.0m;
    }
}
