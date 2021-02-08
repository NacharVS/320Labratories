using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Laboratories320
{
    class Hero : IMovable, IDestroyable
    {

        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        [BsonIgnoreIfDefault]
        public object Id { get; set; }
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

        public static async Task Update (string name, in numberoflife)
        {

        }
    }

   


}
