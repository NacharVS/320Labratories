using System;
using System.Collections.Generic;
using System.Text;
using Laboratories320.Musin.StrategyGame;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Laboratories320.Musin.Mongodb
{
    class Mongo
    {
        public static void MainMongpTest()
        {
            Knight kn1 = new Knight
            {
                Speed = 3,
                Armor = 13,
                Health = 300,
                Damage = 15,
                Name = "Bud"
            };

            Knight kn2 = new Knight
            {
                Speed = 3,
                Armor = 23,
                Health = 500,
                Damage = 15,
                Name = "Brud"
            };
            ReplaceBySpeed(kn2, "Farhat").GetAwaiter().GetResult();

        }
        public static async Task MongoInsert(Knight pot)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Knight>("MusinSystem");
            await collection.InsertOneAsync(pot);

        }
        public static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Knight>("MusinSystem");
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
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Knight>("MusinSystem");
            var students = await collection.Find(std => std.Name == Name).ToListAsync();

            foreach (var item in students)
            {
                Console.WriteLine(item.Armor);
            }
        }

        public static async Task ReplaceBySpeed(Knight kn, string name)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Knight>("MusinSystem");
            await collection.ReplaceOneAsync(std => std.Name == name, kn);
        }

        public static async Task UpdateByName(int speed, string Name)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Knight>("MusinSystem");
            var update = Builders<Knight>.Update.Set<double>(a => a.Speed, speed);
            await collection.UpdateManyAsync(kn => kn.Name == Name, update);
        }

        public static async Task UpdateByNameMany(int speed, string Name)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Knight>("MusinSystem");
            var update = Builders<Knight>.Update.Set(a => a.Speed, speed);
            await collection.UpdateManyAsync(kn => kn.Name == Name, update);
        }

        public static async Task DeleteByName(string Name)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Knight>("MusinSystem");
            await collection.DeleteManyAsync(kn => kn.Name == Name);
        }

        public static async Task DeleteByNameMany(string Name)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Knight>("MusinSystem");
            await collection.DeleteManyAsync(kn => kn.Name == Name);

        }
    }
}