using System;
using System.Threading;
using System.Threading.Tasks;
using Laboratories320.threads;
using MongoDB.Bson;
using MongoDB.Driver;
using Laboratories320.mongobd;


namespace Laboratories320
{
    class Program
    {

        static void Main(string[] args)
        {
            FillMongobd.MongoInsert(new Atacker("Tom",2,45,22,99)).GetAwaiter().GetResult();
            FillMongobd.MongoInsert(new Atacker("Hardy", 5, 66, 29, 90)).GetAwaiter().GetResult();
            FillMongobd.MongoInsert(new Atacker("Tim", 15, 25, 52, 29)).GetAwaiter().GetResult();
            FillMongobd.MongoInsert(new Atacker("Ling", 6, 42, 23, 9)).GetAwaiter().GetResult();
            FillMongobd.MongoInsert(new Atacker("Kiter", 5, 45, 62, 99)).GetAwaiter().GetResult();
            //FillMongobd.SearchByName("Варвулл").GetAwaiter().GetResult();
        }


    }
}




