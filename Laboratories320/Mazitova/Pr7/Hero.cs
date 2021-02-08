using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Threading.Tasks;

namespace Laboratories320
{
    class Hero
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        [BsonIgnoreIfDefault]
        public object HeroId;
        [BsonIgnoreIfNull]
        public string HeroName { get; set; }
        [BsonIgnoreIfDefault]
        public int Health { get; set; }

        public static async Task HeroInsert(Hero h)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Teddy");
            var collection = database.GetCollection<Hero>("Hero");
            await collection.InsertOneAsync(h);
        }
        public static async Task HeroNameResault(string heroName, Hero newHero)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Teddy");
            var collection = database.GetCollection<Hero>("Hero");
            await collection.ReplaceOneAsync(hero => hero.HeroName == heroName, newHero);
        }

        public static async Task UpdateMany(string heroName, int newHealth)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Teddy");
            var collection = database.GetCollection<Hero>("Hero");
            var update = Builders<Hero>.Update.Set(hero => hero.Health, newHealth);
            await collection.UpdateManyAsync(hero => hero.HeroName == heroName, update);
        }
        public static async Task DeleteMany(string heroName, int newHealth)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Teddy");
            var collection = database.GetCollection<Hero>("Hero");
            var delete = Builders<Hero>.Filter.Eq(hero => hero.Health, newHealth);
            await collection.DeleteManyAsync(delete);
        }
        public static async Task Update(string heroName, int newHealth)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Teddy");
            var collection = database.GetCollection<Hero>("Hero");
            var update = Builders<Hero>.Update.Set(hero => hero.Health, newHealth);
            await collection.UpdateOneAsync(hero => hero.HeroName == heroName, update);
        }
        public static async Task Delete(string heroName, int newHealth)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Teddy");
            var collection = database.GetCollection<Hero>("Hero");
            var delete = Builders<Hero>.Filter.Eq(hero => hero.Health, newHealth);
            await collection.DeleteOneAsync(delete);
        }
    }
}
