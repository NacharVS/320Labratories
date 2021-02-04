using System;
using System.Collections.Generic;
using System.Text;
using Laboratories320.Shigapov.StrategyGame;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;


namespace Laboratories320.Shigapov.Mongo
{
    class MongpTest
    {

        public static void MainMongpTest()
        {
            Player z = new Player
            {
                Speed = 3,
                Armor = 13,
                Health = 100,
                Name = "Ivan"
            };

            Player y = new Player
            {
                Speed = 3,
                Armor = 23,
                Health = 100,
                Name = "Alex"
            };
           ReplaceByName(y, "Ivan").GetAwaiter().GetResult();

        }
        public static async Task MongoInsert(Player pot)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Player");
            var collection = database.GetCollection<Player>("CyberSportSystem");
            await collection.InsertOneAsync(pot);

        }
        public static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Player");
            var collection = database.GetCollection<Player>("CyberSportSystem");
            var student = new BsonDocument();
            var students = await collection.Find(student).ToListAsync();

            foreach (var item in students)
            {
                Console.WriteLine(item.Speed);
            }
        }
        public static async Task SearchByName(string Name)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Player");
            var collection = database.GetCollection<Player>("CyberSportSystem");
            var students = await collection.Find(std => std.Name == Name).ToListAsync();

            foreach (var item in students)
            {
                Console.WriteLine(item.Armor);
            }
        }

        public static async Task ReplaceByName(Player Z, string Name)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Player");
            var collection = database.GetCollection<Player>("CyberSportSystem");
            await collection.ReplaceOneAsync(std => std.Name == Name, Z );
        }
    }
}
