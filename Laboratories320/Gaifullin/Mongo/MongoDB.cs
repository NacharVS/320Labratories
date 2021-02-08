using System;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Laboratories320.Gaifullin.Mongo
{
    class MongoDB
    {
        public static async Task MongoInsert(WarUnit pot)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Player");
            var collection = database.GetCollection<WarUnit>("CyberSportSystem");
            await collection.InsertOneAsync(pot);

        }
        public static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Player");
            var collection = database.GetCollection<WarUnit>("CyberSportSystem");
            var student = new BsonDocument();
            var students = await collection.Find(student).ToListAsync();

            foreach (var item in students)
            {
                Console.WriteLine(item.Speed);
            }
        }
        public static async Task SearchBySpeed(double speed)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("MilkyWay");
            var collection = database.GetCollection<WarUnit>("CyberSportSystem");
            var students = await collection.Find(std => std.Speed == speed).ToListAsync();

            foreach (var item in students)
            {
                Console.WriteLine(item.Armor);

            }
        }
    }
}
