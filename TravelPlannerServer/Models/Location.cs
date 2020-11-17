using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TravelPlannerServer.Models
{
    public class Location
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();
        
        [BsonElement("x")]
        public int X { get; set; }
        
        [BsonElement("y")]
        public int Y { get; set; }
        
        [BsonElement("name")]
        public string Name { get; set; }
        
        [BsonElement("weathers")]
        public IEnumerable<WeatherInfo> Weathers { get; set; }
    }
}