using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TravelPlannerServer.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();
        
        [BsonElement("ipAddress")]
        public string IpAddress { get; set; }
    }
}