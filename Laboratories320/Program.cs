using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Laboratories320.task_02._02._21;
using Laboratories320.task_14._01._21;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            Fairy fairy1 = new Fairy() { Name = "Bloom", Kindness = 78, Knowlege = 84, Power = 45, SpesialPower = "Dragon Fire" };
            Fairy fairy2 = new Fairy() { Name = "Aisha", Kindness = 80, Knowlege = 92, Power = 50, SpesialPower = "Water bol" };
            //MongoDBTest.MongoInsert(fairy1).GetAwaiter().GetResult();
            //MongoDBTest.SearchByName("Aisha").GetAwaiter().GetResult();
            MongoDBTest.MongoConnect().GetAwaiter().GetResult();
        }
    }
}
