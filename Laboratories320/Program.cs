using System;
using Laboratories320.Zakirov._1Praktika;
using Laboratories320.Zakirov._2Thread;
using Laboratories320.Zakirov._3ThreadLocker;
using Laboratories320.Zakirov._4ThreadTask;
using Laboratories320.Zakirov._5ContinuationTasks;
using Laboratories320.Zakirov._6GameCreatStart;
using Laboratories320.Zakirov.MongoPraktika1;
using Laboratories320.Zakirov.MongoPraktika2;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            //MethodMongo.MongoInsert(new Barbarian("Варвер", 90, 55, 43, 78, 85, 36)).GetAwaiter().GetResult();
            //MethodMongo.MongoInsert(new Barbarian("Вагир", 93, 14, 64, 23, 86, 46)).GetAwaiter().GetResult();
            //MethodMongo.MongoInsert(new Barbarian("Вайкар", 92, 23, 86, 65, 75, 32)).GetAwaiter().GetResult();
            MethodMongo.MongoInsert(new Barbarian("Чаронор", 92, 23, 86, 65, 75, 32)).GetAwaiter().GetResult();
            MethodMongo.MongoInsert(new Barbarian("Зореан", 92, 23, 86, 65, 75, 32)).GetAwaiter().GetResult();
            //MethodMongo.SearchByName("Варвулл").GetAwaiter().GetResult();

            ReplaceMongo.MongoReplace(new Barbarian("Нароган", 43, 75, 17, 86, 87, 43), "Вагир").GetAwaiter().GetResult();
        }
    }
}
