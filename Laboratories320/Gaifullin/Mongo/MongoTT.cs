using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Gaifullin.Mongo
{
    class MongoTT
    {
        string connectionString = "mongodb://localhost:27017";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("MilkyWay");
        var database = client.GetDatabase("Player");
        var collection = database.GetCollection<WarUnit>("CyberSportSystem");
        var students = await collection.Find(std => std.Speed == speed).ToListAsync();

            foreach (var item in students)
            {
                Console.WriteLine(item.Armor);
            
            }
}

     public static async Task ReplaceBySpeed(double speed, WarUnit Z)
   {
    string connectionString = "mongodb://localhost:27017";
    var client = new MongoClient(connectionString);
    var database = client.GetDatabase("Player");
    var collection = database.GetCollection<WarUnit>("CyberSportSystem");
    var students = collection.ReplaceOne(std => std.Speed == speed, Z);
   }
    }
    

