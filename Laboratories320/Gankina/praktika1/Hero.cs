using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Laboratories320
{
    class Hero
    {
        [BsonId]
        public int HeroId;
        [BsonIgnoreIfNull]
        public string Name { get; set; }
        [BsonIgnoreIfDefault]
        public double Cost { get; set; }
        [BsonIgnoreIfDefault]
        public int NumberOfLife { get; set; }

        public void Move()
        {

        }

        public void Destroy()
        {

        }

        public static async Task HeroInsert(Hero h)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Milka");
            var collection = database.GetCollection<Hero>("Hero");
            await collection.InsertOneAsync(h);

        }
        public static async Task ReplaceByName(string newname, Hero newhero)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Milka");
            var collection = database.GetCollection<Hero>("Hero");
            await collection.ReplaceOneAsync(hero => hero.Name == newname, newhero);
        }

        public static async Task Update(string name, int numberoflife)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Milka");
            var collection = database.GetCollection<Hero>("Hero");
            var update = Builders<Hero>.Update.Set(h => h.NumberOfLife, numberoflife);
            await collection.UpdateOneAsync(hero => hero.Name == name, update);
        }

        public static async Task UpdateMany(string name, int numberoflife)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Milka");
            var collection = database.GetCollection<Hero>("Hero");
            var update = Builders<Hero>.Update.Set(h => h.NumberOfLife, numberoflife);
            await collection.UpdateManyAsync(hero => hero.Name == name, update);
        }

    }
}
