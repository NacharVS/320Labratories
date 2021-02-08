using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using Laboratories320.Volkov._1_practice;
using Laboratories320.Volkov._1_practice.War_Units;

namespace Laboratories320.Volkov.MongoMethod1
{
    class Method1
    {
        public static async Task MongoInsert(Archer archer)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Archer>("Archers");
            await collection.InsertOneAsync(archer);
        }
        public static async Task SearchByName(string searchName)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Archer>("Archers");
            var archers = await collection.Find(std => std.Name == searchName).ToListAsync();

            foreach (var item in archers)
            {
                Console.WriteLine(item.Name);
            }
        }
        public static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Archer>("Archers");
            var archer = new BsonDocument();
            var archers = await collection.Find(archer).ToListAsync();

            foreach (var item in archers)
            {
                Console.WriteLine(item.Name);

            }
        }
    }
}
