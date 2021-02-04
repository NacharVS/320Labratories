using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using Laboratories320.Hamatullin._1praktik;
using System.Threading.Tasks;

namespace Laboratories320.Hamatullin.Mongo2praktik
{
    class MongoReplace
    {
        //готово
        public static async Task ReplaceMongo(Archer archer, string nameArcher)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Archer>("Archers");
            await collection.ReplaceOneAsync(archer => archer.Name == nameArcher, archer);
        }
    }
}
