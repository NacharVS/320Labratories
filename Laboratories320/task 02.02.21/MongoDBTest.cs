using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Laboratories320.task_14._01._21;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Laboratories320.task_02._02._21
{
    class MongoDBTest
    {
        public static async Task MongoInsert(Fairy fairy)
        {
            var database = new MongoClient("mongodb://localhost:27017").GetDatabase("WarOfHarmony");
            var collection = database.GetCollection<Fairy>("Alphea");
            await collection.InsertOneAsync(fairy);
        }


        public static async Task MongoConnect()
        {
            var database = new MongoClient("mongodb://localhost:27017").GetDatabase("WarOfHarmony");
            var collection = database.GetCollection<Fairy>("Alphea");
            var fairy = new BsonDocument();
            var fairis = await collection.Find(fairy).ToListAsync();
            foreach (var item in fairis)
            {
                Console.WriteLine(item.Name);

            }
        }

        public static async Task SearchByName(string searchName)
        {
            var database = new MongoClient("mongodb://localhost:27017").GetDatabase("WarOfHarmony");
            var collection = database.GetCollection<Fairy>("Alphea");
            var fairis = await collection.Find(fair => fair.Name == searchName).ToListAsync();
            foreach (var item in fairis)
            {
                Console.WriteLine(item.SpesialPower);

            }
        }
    }
}
