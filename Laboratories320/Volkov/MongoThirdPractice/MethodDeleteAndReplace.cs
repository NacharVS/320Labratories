using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using Laboratories320.Volkov._1_practice;
using Laboratories320.Volkov._1_practice.War_Units;



namespace Laboratories320.Volkov.MongoThirdPractice
{
    class MethodDeleteAndReplace
    {
        public static async Task UpdateMongo(string name, int newDamage)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Archer>("Archers");
            var update = Builders<Archer>.Update.Set(archer => archer.Damage, newDamage);
            await collection.UpdateOneAsync(archer => archer.Name == name, update);
        }
        public static async Task UpdateMongoMany(string name, int newDamage)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Archer>("Archers");
            var update = Builders<Archer>.Update.Set(archer => archer.Damage, newDamage);
            await collection.UpdateManyAsync(archer => archer.Name == name, update);
        }
        public static async Task DeleteMongo(string name)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Archer>("Archers");
            await collection.DeleteOneAsync(archer => archer.Name == name);

        }
        public static async Task DeleteMongoMany(string name)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Archer>("Archers");
            await collection.DeleteManyAsync(archer => archer.Name == name);
        }
    }
}
