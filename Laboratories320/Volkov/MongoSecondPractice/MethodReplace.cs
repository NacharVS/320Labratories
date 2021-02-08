using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using Laboratories320.Volkov._1_practice;
using Laboratories320.Volkov._1_practice.War_Units;

namespace Laboratories320.Volkov.MongoSecondPractice
{
    class MethodReplace
    {
        public static async Task ReplaceMongo(Archer archer, string nameArcher)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Archer>("Archers");
            await collection.ReplaceOneAsync(archer => archer.Name == nameArcher, archer);
        }
        public static async Task ReplaceMongoUpsert(Archer archer, string nameArcher)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Archer>("Archers");
            await collection.ReplaceOneAsync(archer => archer.Name == nameArcher, archer, new ReplaceOptions { IsUpsert = true });
        }
    }
}
