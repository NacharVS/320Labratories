using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using Laboratories320.Zakirov._1Praktika;

namespace Laboratories320.Zakirov.MongoPraktika2
{
    class ReplaceMongo
    {
        public static async Task MongoReplace(Barbarian barbarian, string nameBarbarian)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Barbarian>("Barbarians");
            await collection.ReplaceOneAsync(barbarian => barbarian.Name == nameBarbarian, barbarian, new ReplaceOptions { IsUpsert = true });
        }
    }
}
