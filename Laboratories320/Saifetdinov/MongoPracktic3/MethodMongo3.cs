using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MongoDB.Bson;
using MongoDB.Driver;
using Laboratories320.Saifetdinov.StrategyGame;

namespace Laboratories320.Saifetdinov.MongoPracktic3
{
    class MethodMongo3
    {
        public static async Task MongoUpdateMany(string serachName, int newLevel)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var dataBase = client.GetDatabase("MondoHealer");
            var collection = dataBase.GetCollection<Healer>("healer");
            var update = Builders<Healer>.Update.Set(h => h.Level, newLevel);
            await collection.UpdateManyAsync(heal => heal.Name == serachName, update);
        }

        public static async Task MongoUpdateOne(string serachName, int health)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var dataBase = client.GetDatabase("MondoHealer");
            var collection = dataBase.GetCollection<Healer>("healer");
            var update = Builders<Healer>.Update.Set(h => h.Level, health);
            await collection.UpdateOneAsync(heal => heal.Name == serachName, update);
        }

        public static async Task MongoDeleteMany(string serachName)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var dataBase = client.GetDatabase("MondoHealer");
            var collection = dataBase.GetCollection<Healer>("healer");
            await collection.DeleteManyAsync(heal => heal.Name == serachName);
        }

        public static async Task MongoDeleteOne(string serachName)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var dataBase = client.GetDatabase("MondoHealer");
            var collection = dataBase.GetCollection<Healer>("healer");
            await collection.DeleteOneAsync(heal => heal.Name == serachName);
        }

    }
}
