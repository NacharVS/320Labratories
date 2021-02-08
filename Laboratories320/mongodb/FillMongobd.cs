using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;
using System.Threading;

namespace Laboratories320.mongobd
{
    class FillMongobd
    {
        public static async Task MongoInsert(Atacker atc)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Atacker>("Atackers");
            await collection.InsertOneAsync(atc);
        }

        public static async Task SearchByName(string searchName)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Atacker>("Atackers");
            var atackers = await collection.Find(std => std.Name == searchName).ToListAsync();

            foreach (var item in atackers)
            {
                Console.WriteLine(item.Name);
            }
        }
        public static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Atacker>("Atackers");
            var atacker = new BsonDocument();
            var atackers = await collection.Find(atacker).ToListAsync();

            foreach (var item in atackers)
            {
                Console.WriteLine(item.Name);

            }
        }
        public static async Task Replace(Atacker atc, string nameArcher)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Atacker>("Atackers");
            await collection.ReplaceOneAsync(archer => archer.Name == nameArcher, atc, new ReplaceOptions { IsUpsert = true });

        }
        public static async Task MongoUpdate(string searchName, double newLevel)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Atacker>("Atackers");
            var update = Builders<Atacker>.Update.Set(x => x.Level, newLevel);
            await collection.UpdateManyAsync(atc => atc.Name == searchName, update);
        }

    }
}
