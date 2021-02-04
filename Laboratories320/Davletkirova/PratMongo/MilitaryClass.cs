using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Laboratories320.Cherginova.PratMongo
{
    class MilitaryClass
    {
        public static async Task MongoInsert(Military military)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("StrategyGame");
            var collection = database.GetCollection<Military>("Military");
            await collection.InsertOneAsync(military);
        }

        public static async Task SearchByName(string searchName)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("StrategyGame");
            var collection = database.GetCollection<Military>("Military");
            var military = await collection.Find(std => std.Name == searchName).ToListAsync();

            foreach (var item in military)
            {
                Console.WriteLine(item.Name);
            }
        }
        public static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("StrategyGame");
            var collection = database.GetCollection<Military>("Military");
            var military = new BsonDocument();
            var militaries = await collection.Find(military).ToListAsync();

            foreach (var item in military)
            {
                Console.WriteLine(item.Name);

            }

        }
    }
}
