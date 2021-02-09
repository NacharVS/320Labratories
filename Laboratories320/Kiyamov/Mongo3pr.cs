using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MongoDB.Bson;
using MongoDB.Driver;
using Laboratories320.Kiyamov._1_Praktika;

namespace Laboratories320.Kiyamov
{
    class Mongo3pr
    {

        public static async Task MongoUpdate1(string searchName, int health)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var dataBase = client.GetDatabase("MondoBuilder");
            var collection = dataBase.GetCollection<Healer>("builder");
            var update = Builders<Builder>.Update.Set(b => b.Level, health);
            await collection.UpdateOneAsync(builder => builder.Name == searchName, update);
        }
        public static async Task MongoUpdateMany(string searchName, int newLevel)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var dataBase = client.GetDatabase("MondoBuilder");
            var collection = dataBase.GetCollection<Healer>("healer");
            var update = Builders<Builder>.Update.Set(b => b.Level, newLevel);
            await collection.UpdateManyAsync(builder => builder.builder == searchName, update);
        }
        public static async Task MongoDelete1(string searchName)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var dataBase = client.GetDatabase("MondoBuilder");
            var collection = dataBase.GetCollection<Builder>("Builder");
            await collection.DeleteOneAsync(builder => builder.Name == searchName);
        }


        public static async Task MongoDeleteMany(string searchName)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var dataBase = client.GetDatabase("MondoBuilder");
            var collection = dataBase.GetCollection<Builder>("Builder");
            await collection.DeleteManyAsync(builder => builder.Name == searchName);
  
            
        }
    

    }
}
    