using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Libmongocrypt;
using Laboratories320.Saifetdinov.StrategyGame;
using Laboratories320.Saifetdinov.MongoPracktic1;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            //MethodMongo.MongoInsert(new Healer("Bill", 12, 100, 2, 25, 10, 15, 10, 9)).GetAwaiter().GetResult();

            MethodMongo.SearchByName("Ранис").GetAwaiter().GetResult();
            MethodMongo.MongoConnect().GetAwaiter().GetResult();
        }
    }
}
