using System;
using Laboratories320.Zakirov._1Praktika;
using Laboratories320.Zakirov._2Thread;
using Laboratories320.Zakirov._3ThreadLocker;
using Laboratories320.Zakirov._4ThreadTask;
using Laboratories320.Zakirov._5ContinuationTasks;
using Laboratories320.Zakirov._6GameCreatStart;
using Laboratories320.Zakirov.MongoPraktika1;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodMongo.MongoInsert(new Barbarian("Варвер", 90, 55, 43, 78, 85, 36)).GetAwaiter().GetResult();
            MethodMongo.SearchByName("Варвулл").GetAwaiter().GetResult();
        }
    }
}
