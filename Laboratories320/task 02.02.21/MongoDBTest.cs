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
        public static void MainMongo()
        {
            Fairy fairy1 = new Fairy() { Name = "Bloom", Kindness = 78, Knowlege = 84, Power = 45, SpesialPower = "Dragon Fire" };
            Fairy fairy2 = new Fairy() { Name = "Aisha", Kindness = 80, Knowlege = 92, Power = 50, SpesialPower = "Water bol" };
            Fairy fairy3 = new Fairy() { Name = "Flora", Kindness = 90, Knowlege = 88, Power = 40, SpesialPower = "Flover pal" };
            Fairy fairy4 = new Fairy() { Name = "Stella", Kindness = 60, Knowlege = 30, Power = 40, SpesialPower = "Sun power" };
            Fairy fairy5 = new Fairy() { Name = "Blo0000om", Kindness = 78, Knowlege = 84, Power = 45, SpesialPower = "Dragon Fire" };

            //MongoInsert(fairy1).GetAwaiter().GetResult();
            //MongoInsert(fairy2).GetAwaiter().GetResult();
            //MongoInsert(fairy3).GetAwaiter().GetResult();
            //MongoInsert(fairy4).GetAwaiter().GetResult();
            //MongoInsert(fairy5).GetAwaiter().GetResult();

            //MongoDBTest.SearchByName("Aisha").GetAwaiter().GetResult();
            //MongoDBTest.MongoConnect().GetAwaiter().GetResult();
            //MongoDBTest.UpdatePerson(fairy3, "Bloom").GetAwaiter().GetResult();

            //UpdatePerson("Flora", "Flower dust").GetAwaiter().GetResult();
            //DeletePerson("Blo0000om").GetAwaiter().GetResult();

        }
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

        public static async Task ReplacePers(Fairy fairy, string fairyName)
        {
            var database = new MongoClient("mongodb://localhost:27017").GetDatabase("WarOfHarmony");
            var collection = database.GetCollection<Fairy>("Alphea");
            await collection.ReplaceOneAsync(fair => fair.Name == fairyName, fairy);
        }

        public static async Task UpdatePerson(string fairyName, string spesialPower)
        {
            var database = new MongoClient("mongodb://localhost:27017").GetDatabase("WarOfHarmony");
            var collection = database.GetCollection<Fairy>("Alphea");
            var update = Builders<Fairy>.Update.Set(x => x.SpesialPower, spesialPower);
            await collection.UpdateOneAsync(fair => fair.Name == fairyName, update);
        }

        public static async Task DeletePerson(string fairyName)
        {
            var database = new MongoClient("mongodb://localhost:27017").GetDatabase("WarOfHarmony");
            var collection = database.GetCollection<Fairy>("Alphea");
            await collection.DeleteOneAsync(fair => fair.Name == fairyName);
        }
    }
}
