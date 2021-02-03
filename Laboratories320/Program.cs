using System;
using Laboratories320.Shigapov.Practic2;
using Laboratories320.Shigapov.Task3;
using Laboratories320.Shigapov.Task1;
using System.Threading;
using System.Threading.Tasks;
using Laboratories320.Shigapov.ContinuationTasks;
using Laboratories320.Shigapov.GameCreationStart;
using Laboratories320.Shigapov.StrategyGame;
using Laboratories320.Shigapov.Mongo;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leave hope behind all who enters here....");
            Console.WriteLine();
            //Continuation
            int[] array = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                array[i] = rnd.Next(1, 10);
            }
            Console.WriteLine("Generating");
            Console.WriteLine("[{0}]", string.Join(", ", array));
            Task task1 = Task.Run(() => Continuation.Сomposition(array));
            Task task2 = task1.ContinueWith(mul => Continuation.Even());
            task2.Wait();
            //
            WarUnit z = new WarUnit
            {
                Speed = 3,
                Armor = 13
            };
            MongpTest.MongoInsert(z);

        }
    }
}
