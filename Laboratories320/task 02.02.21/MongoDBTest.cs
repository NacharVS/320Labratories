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
        public static void MainMongoDB()
        {
            Fairy fairy = new Fairy() {Name = "Bloom", Kindness = 78, Knowlege = 84, Power = 45, SpesialPower = "Dragon Fire" };
            MongoInsert(fairy);
        }

        static async Task MongoInsert(Fairy fairy)
        {
            var database = new MongoClient("mongodb://localhost").GetDatabase("WarOfHarmony");
            var collection = database.GetCollection<Fairy>("Alphea");
            await collection.InsertOneAsync(fairy);
        }


        static async Task MongoConnect()
        {
            var database = new MongoClient("mongodb://localhost").GetDatabase("WarOfHarmony");
            var collection = database.GetCollection<Fairy>("Alphea");
            var fairy = new BsonDocument();
            var fairis = await collection.Find(fairy).ToListAsync();
            foreach (var item in fairis)
            {
                Console.WriteLine(item.Name);

            }
        }

        static async Task SearchByName(string searchName)
        {
            var database = new MongoClient("mongodb://localhost").GetDatabase("WarOfHarmony");
            var collection = database.GetCollection<Fairy>("Alphea");
            var fairis = await collection.Find(fair => fair.Name == searchName).ToListAsync();
            foreach (var item in fairis)
            {
                Console.WriteLine(item.SpesialPower);

            }

        }
    }
}
