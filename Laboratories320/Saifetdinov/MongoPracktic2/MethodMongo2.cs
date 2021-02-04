using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MongoDB.Driver;
using MongoDB.Bson;
using Laboratories320.Saifetdinov.StrategyGame;

namespace Laboratories320.Saifetdinov.MongoPractic2
{
    class MethodMongo2
    {
        public static async Task Replace(Healer healer, string newNameHealer)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("MondoHealer");
            var collection = database.GetCollection<Healer>("healer");
            await collection.ReplaceOneAsync(heal => heal.Name == newNameHealer, healer);


        }
        public static async Task Replace2(Healer healer, string newNameHealer)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("MondoHealer");
            var collection = database.GetCollection<Healer>("healer");
            await collection.ReplaceOneAsync(heal => heal.Name == newNameHealer, healer, new ReplaceOptions { IsUpsert = true });
        }

    }
}
