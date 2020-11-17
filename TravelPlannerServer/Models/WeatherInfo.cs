using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TravelPlannerServer.Models
{
    public class WeatherInfo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();
        
        [BsonElement("temperatureC")]
        public float TemperatureC { get; set; }
        
        [BsonElement("temperatureF")]
        public float TemperatureF => (TemperatureC + 32) / (5 / 9);
        
        [BsonElement("timestamp")]
        public DateTime Timestamp { get; set; }
    }
}