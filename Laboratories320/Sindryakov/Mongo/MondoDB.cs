using System;
using System.Collections.Generic;
using System.Text;
using Laboratories320.Sindryakov.StrategyGame;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Laboratories320.Sindryakov.Mongo
{
    class MondoDB
    {
        public static void MainMondoDB()
        {
            Archer u1 = new Archer
            {
                Speed = 10,
                Force = 55,
                Name = "Valera",
            };

            Archer u2 = new Archer
            {
                Speed = 10,
                Force = 33,
                Name = "Vilen",
            };
            ReplaceByName(u2, "Valera").GetAwaiter().GetResult();
        }

        public static async Task MongoInsert(Archer potato)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("User");
            var collection = database.GetCollection<Archer>("ValSystem");
            await collection.InsertOneAsync(potato);

        }
        public static async Task MongoConnect()
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("User");
            var collection = database.GetCollection<Archer>("ValSystem");
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
            var database = client.GetDatabase("User");
            var collection = database.GetCollection<Archer>("ValSystem");
            var students = await collection.Find(std => std.Name == Name).ToListAsync();

            foreach (var item in students)
            {
                Console.WriteLine(item.Force);
            }
        }

        public static async Task ReplaceByName(Archer A, string Name)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("User");
            var collection = database.GetCollection<Archer>("ValSystem");
            await collection.ReplaceOneAsync(std => std.Name == Name, A);
        }
    }
}

