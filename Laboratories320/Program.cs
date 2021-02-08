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

             (FillMongobd.MongoUpdate("Tom", 23)).GetAwaiter().GetResult();

        }


    }
}




