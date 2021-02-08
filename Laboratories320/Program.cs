using System;
using Laboratories320.Zakirov._1Praktika;
using Laboratories320.Zakirov._2Thread;
using Laboratories320.Zakirov._3ThreadLocker;
using Laboratories320.Zakirov._4ThreadTask;
using Laboratories320.Zakirov._5ContinuationTasks;
using Laboratories320.Zakirov._6GameCreatStart;
using Laboratories320.Zakirov.MongoPraktika1;
using Laboratories320.Zakirov.MongoPraktika2;
using Laboratories320.Zakirov.MongoPraktika3;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            UpdatelDeleteMongo.MongoOneUpdate("Варол", 65).GetAwaiter().GetResult();
            //UpdatelDeleteMongo.MongoManyUpdate("Варол", 12).GetAwaiter().GetResult();
            //UpdatelDeleteMongo.MongoOneDelete("Варол").GetAwaiter().GetResult();
            //UpdatelDeleteMongo.MongoManyDelete("Варол").GetAwaiter().GetResult();
        }
    }
}
