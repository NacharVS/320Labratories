using Laboratories320.Smirnov.StrategyGame_1_.Units.War_units;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Smirnov.Mongo_7_
{
    static class MethodsForMongo
    {
        public static async Task MongoInsert(Assasin assasin)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("StrategyGame");
            var collection = database.GetCollection<Assasin>("Assasin");
            await collection.InsertOneAsync(assasin);
        }
        public static async Task SearchByName(string searchName)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("StrategyGame");
            var collection = database.GetCollection<Assasin>("Assasin");
            var archers = await collection.Find(fn => fn.Name == searchName).ToListAsync();

            foreach (var item in archers)
            {
                Console.WriteLine(item.Name);
            }
        }
        public static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("StrategyGame");
            var collection = database.GetCollection<Assasin>("Assasin");
            var assasin = new BsonDocument();
            var assasins = await collection.Find(assasin).ToListAsync();

            foreach (var item in assasins)
            {
                Console.WriteLine(item.Name);
            }
        }

        public static async Task ReplaceByName(Assasin assasin, string name)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("StrategyGame");
            var collection = database.GetCollection<Assasin>("Assasin");
            await collection.ReplaceOneAsync(std => std.Name == name, assasin);
        }
    }
}
