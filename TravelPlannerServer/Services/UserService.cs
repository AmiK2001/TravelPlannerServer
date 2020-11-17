using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;
using TravelPlannerServer.Models;

namespace TravelPlannerServer.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService(TravelPlannerDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _users = database.GetCollection<User>(settings.UsersCollectionName);
        }

        public List<User> Get() =>
            _users.Find(user => true).ToList();

        public User Get(BsonObjectId id) =>
            _users.Find<User>(user => user.Id == id).FirstOrDefault();

        public User Create(User user)
        {
            _users.InsertOne(user);
            return user;
        }

        public void Update(BsonObjectId id, User userIn) =>
            _users.ReplaceOne(user => user.Id == id, userIn);

        public void Remove(User userIn) =>
            _users.DeleteOne(user => user.Id == userIn.Id);

        public void Remove(BsonObjectId id) => 
            _users.DeleteOne(user => user.Id == id);
    }
}