using System;
using System.Threading;
using Laboratories320.Lab2;
using Laboratories320.Lab3;
using Laboratories320.Lab4;
using Laboratories320.Lab5;

namespace Laboratories320
{
    class Program
    {

        static void Main(string[] args)
        {
            //Random rnd = new Random();
            //int[] arr = new int[10];
            //foreach (var item in arr)
            //{
            //arr[1] = rnd.Next(-10, 20);
            //}
            //Threading th = new Threading(arr);
            //th.Start();

            //Threading2 thr = new Threading2();
            //thr.Start();

            //Tasking t1 = new Tasking();
            //t1.Start();
            /*Tasking2 task = new Tasking2();
            task.Start();*/


            Hero h = new Hero
            {
                Name = "Hero21",
                Cost = 4000
            };

          /*  Hero.HeroInsert(h).GetAwaiter().GetResult();*/
            Hero.ReplaceByName("Hero1", h).GetAwaiter().GetResult();
        }

    }
}







        
    




    

