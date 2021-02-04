using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MongoDB.Driver;
using MongoDB.Bson;
using Laboratories320.Saifetdinov.StrategyGame;


namespace Laboratories320.Saifetdinov.MongoPracktic1
{
    class MethodMongo
    {
        public static async Task MongoInsert(Healer healer)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("MondoHealer");
            var collection = database.GetCollection<Healer>("healer");
            await collection.InsertOneAsync(healer);
        }

        public static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("MondoHealer");
            var collection = database.GetCollection<StrategyGame.Healer>("HealerSystem");
            var healer = new BsonDocument();
            var healers = await collection.Find(healer).ToListAsync();

            foreach (var item in healers)
            {
                Console.WriteLine($"{item.Name}");
            }
        }

        public static async Task SearchByName(string serachName)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("MondoHealer");
            var collection = database.GetCollection<Healer>("healer");
            var healers = await collection.Find(heal => heal.Name == serachName).ToListAsync();

            foreach (var item in healers)
            {
                Console.WriteLine(item.Name);
            }
        }

    }
}
