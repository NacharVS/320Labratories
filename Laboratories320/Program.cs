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
                Name = "Hero221",
                Cost = 4000
            };
            Hero h1 = new Hero
            {
                Name = "Hero2",
                Cost = 2200,
                NumberOfLife = 4
            };
            Hero h2 = new Hero
            {
                Name = "Hero3",
                Cost = 4600,
                NumberOfLife = 7
            };


            Hero.HeroInsert(h1).GetAwaiter().GetResult();
            Hero.HeroInsert(h2).GetAwaiter().GetResult();
           /* Hero.ReplaceByName("Hero21", h).GetAwaiter().GetResult();*/
        }

    }
}







        
    




    

