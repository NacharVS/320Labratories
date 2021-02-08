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
using Laboratories320.Saifetdinov.MongoPractic2;
using Laboratories320.Saifetdinov.MongoPracktic3;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            //MethodMongo.MongoInsert(new Healer("Bill", 12, 100, 2, 25, 10, 15, 10, 9)).GetAwaiter().GetResult();
            //MethodMongo.SearchByName("Ранис").GetAwaiter().GetResult();
            //MethodMongo.MongoConnect().GetAwaiter().GetResult();
            //MethodMongo.MongoInsert(new Healer("Po", 1, 15, 2, 4, 10, 1, 6, 7)).GetAwaiter().GetResult();
            //MethodMongo.MongoInsert(new Healer("Po", 1, 15, 2, 4, 10, 1, 6, 7)).GetAwaiter().GetResult();
            //MethodMongo.MongoInsert(new Healer("Po", 1, 15, 2, 4, 10, 1, 6, 7)).GetAwaiter().GetResult();
            //MethodMongo3.MongoUpdateOne("Ran", 20).GetAwaiter().GetResult();
            //MethodMongo3.MongoDeleteMany("Po").GetAwaiter().GetResult();
            MethodMongo3.MongoDeleteOne("Po").GetAwaiter().GetResult();
        }
    }
}
