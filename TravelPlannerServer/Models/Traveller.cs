using MongoDB.Bson.Serialization.Attributes;

namespace TravelPlannerServer.Models
{
    public class Traveller
    {
        [BsonElement("firstName")]
        public string FirstName { get; set; }
        
        [BsonElement("lastName")]
        public string LastName { get; set; }
        
        [BsonElement("patronymic")]
        public string Patronymic { get; set; }
        
        [BsonElement("age")]
        public int Age { get; set; }

        [BsonElement("user")]
        public User User { get; set; }
    }
}