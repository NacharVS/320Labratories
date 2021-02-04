using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using Laboratories320.Zakirov._1Praktika;
using System.Threading.Tasks;
using System.Threading;

namespace Laboratories320.Zakirov.MongoPraktika1
{
    class MethodMongo
    {
        public static async Task MongoInsert(Barbarian barbarian)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Barbarian>("Barbarians");
            await collection.InsertOneAsync(barbarian);
        }

        public static async Task SearchByName(string searchName)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Barbarian>("Barbarians");
            var barbarians = await collection.Find(std => std.Name == searchName).ToListAsync();

            foreach (var item in barbarians)
            {
                Console.WriteLine(item.Name);
            }
        }
        public static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Barbarian>("Barbarians");
            var barbarian = new BsonDocument();
            var barbarians = await collection.Find(barbarian).ToListAsync();

            foreach (var item in barbarians)
            {
                Console.WriteLine(item.Name);

            }
        }
    }
}
