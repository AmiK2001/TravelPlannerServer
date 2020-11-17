using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TravelPlannerServer.Models
{
    public class Goodie : ICostable
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public BsonObjectId Id { get; set; } = ObjectId.GenerateNewId();
        
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("cost")]
        public double Cost { get; set; }
        
        [BsonElement("quantity")]
        public int Quantity { get; set; }
    }
}