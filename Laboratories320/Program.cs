using Laboratories320.Hamatullin._1praktik;
using Laboratories320.Hamatullin._2praktik;
using Laboratories320.Hamatullin._3praktik;
using Laboratories320.Hamatullin._4praktik;
using Laboratories320.Hamatullin._5praktik;
using Laboratories320.Hamatullin._6praktik;
using Laboratories320.Hamatullin.Mongo1praktik;
using Laboratories320.Hamatullin.Mongo2praktik;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            //MongoMethod.MongoInsert(new Archer("Артемида", 999, 999, 999, 999)).GetAwaiter().GetResult();
            //MongoMethod.SearchByName("Даниил").GetAwaiter().GetResult();
            //MongoMethod.MongoConnect().GetAwaiter().GetResult();
            //MongoReplace.ReplaceMongo(new Archer("Finn", 300, 30, 100, 50), "Даниил").GetAwaiter().GetResult();
            MongoReplace.ReplaceMongoUpsert(new Archer("Гильгамеш", 699, 90, 500, 600),"Ктото неизвестный").GetAwaiter().GetResult();

        }
    }
}
