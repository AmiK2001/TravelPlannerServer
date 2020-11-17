using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TravelPlannerServer.Models
{
    public class Travel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();
        
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("travellers")]
        public IEnumerable<Traveller> Travellers { get; set; }
        
        [BsonElement("goodies")]
        public IEnumerable<Goodie> Goodies { get; set; }
        
        [BsonElement("transportWastes")]
        public IEnumerable<TransportWaste> TransportWastes { get; set; }
        
        [BsonElement("locations")]
        public IEnumerable<Location> Locations { get; set; }
        
        [BsonElement("planners")]
        public IEnumerable<Traveller> Planners { get; set; }

        public double TotalGoodiesCost => Goodies.Aggregate(0.0, (i, goodie) => i + goodie.Cost);
        public double TotalWastesCost => TransportWastes.Aggregate(0.0, (d, waste) => d + waste.Cost);
        public double TotalCost => TotalGoodiesCost + TotalWastesCost;
    }
}