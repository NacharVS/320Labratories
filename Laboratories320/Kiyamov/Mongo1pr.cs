using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MongoDB.Bson;
using MongoDB.Driver;
using Laboratories320.Kiyamov._1_Praktika;

namespace Laboratories320.Kiyamov
{
    class Mongo1pr 
    { 

    public static async Task MongoInsert(Builder builder)
    {
        string connectionString = "mongodb://localhost:27017";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("Game");
        var collection = database.GetCollection<Builder>("Archers");
        await collection.InsertOneAsync(builder);
    }
    public static async Task SearchByName(string searchName)
    {
        string connectionString = "mongodb://localhost:27017";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("Game");
        var collection = database.GetCollection<Archer>("Archers");
        var builder = await collection.Find(std => std.Name == searchName).ToListAsync();

        foreach (var item in builder)
        {
            Console.WriteLine(item.Name);
        }
    }
    public static async Task MongoConnect()
    {
        string connectionString = "mongodb://localhost:27017";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("Game");
        var collection = database.GetCollection<Archer>("Archers");
        var builder = new BsonDocument();
        var builders = await collection.Find(builder).ToListAsync();

        foreach (var item in builder)
        {
            Console.WriteLine(item.Name);

        }
    }
}
}
