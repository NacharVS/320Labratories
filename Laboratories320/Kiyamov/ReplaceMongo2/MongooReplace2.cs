using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using Laboratories320.Kiyamov._1_Praktika;
using System.Threading.Tasks;

namespace Laboratories320.Kiyamov.ReplaceMongo2
{
    class MongooReplace2
    {
        public static async Task Replace1(Builder builder, string newNameBuilder)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("MondoBuilderr");
            var collection = database.GetCollection<Builder>("builder");
            await collection.ReplaceOneAsync(builder => builder.Name == newNameBuilder, builder);


        }
        public static async Task Replace2(Builder builder, string newNameBuilder)
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("MondoBuilderr");
            var collection = database.GetCollection<Builder>("builder");
            await collection.ReplaceOneAsync(builder => builder.Name == newNameBuilder, builder, new ReplaceOptions { IsUpsert = true });
        }

    }
}
