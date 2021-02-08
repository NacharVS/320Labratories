using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using Laboratories320.Zakirov._1Praktika;

namespace Laboratories320.Zakirov.MongoPraktika3
{
    class UpdatelDeleteMongo
    {
        public static async Task MongoOneUpdate(string name, int amountResource)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Barbarian>("Barbarians");
            var update = Builders<Barbarian>.Update.Set(barbarian => barbarian.AmountResources, amountResource);
            await collection.UpdateOneAsync(barbarian => barbarian.Name == name, update);
        }

        public static async Task MongoManyUpdate(string name, int amountResource)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Barbarian>("Barbarians");
            var update = Builders<Barbarian>.Update.Set(barbarian => barbarian.AmountResources, amountResource);
            await collection.UpdateManyAsync(barbarian => barbarian.Name == name, update);
        }

        public static async Task MongoOneDelete(string name)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Barbarian>("Barbarians");
            await collection.DeleteOneAsync(barbarian => barbarian.Name == name);
        }

        public static async Task MongoManyDelete(string name)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Barbarian>("Barbarians");
            await collection.DeleteManyAsync(barbarian => barbarian.Name == name);
        }
    }
}
