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
        public static async Task HeroNameResault (string heroName, Hero newHero)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Teddy");
            var collection = database.GetCollection<Hero>("Hero");
            await collection.ReplaceOneAsync(hero => hero.HeroName == heroName, newHero);
        }

    }
}
