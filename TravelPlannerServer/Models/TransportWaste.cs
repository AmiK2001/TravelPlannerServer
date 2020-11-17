using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TravelPlannerServer.Models
{
    public class TransportWaste : ICostable
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();
        
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("locationTo")]
        public Location LocationTo { get; set; }
        
        [BsonElement("locationFrom")]
        public Location LocationFrom { get; set; }
        
        [BsonElement("cost")]
        public double Cost { get; set; }
        
        [BsonElement("quantity")]
        public int Quantity { get; set; }
    }
}