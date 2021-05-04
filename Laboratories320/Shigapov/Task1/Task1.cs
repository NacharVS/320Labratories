using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Shigapov.Task1
{
    class Task1
    {

        public static int[] array1 = new int[10];
        public static int[] array2 = new int[10];
        public static int[] array3 = new int[10];

        static object SumLocker = new object();
        static object ResultLocker = new object();

        public static void Base()
        {
            Task task1 = new Task(() =>
            {
                lock (SumLocker)
                {
                    Random rnd = new Random();
                    for (int i = 0; i < 10; i++)
                    {
                        lock (SumLocker)
                        {
                            array1[i] = rnd.Next(-10, 10);
                            array2[i] = rnd.Next(-10, 10);
                        }
                    }
                    Console.WriteLine("Generating");

                    Task task2 = Task.Factory.StartNew(() =>
                    {
                        lock (SumLocker)
                        {
                            lock (ResultLocker)
                            {
                                for (int i = 0; i < 10; i++)
                                {
                                    array3[i] = array1[i] + array2[i];
                                }
                                Console.WriteLine("Sum");
                            }
                        }
                    }, TaskCreationOptions.AttachedToParent);

                }
            });
            task1.Start();
            task1.Wait();

            Console.WriteLine("[{0}]", string.Join(", ", array1));
            Console.WriteLine("[{0}]", string.Join(", ", array2));
            Console.WriteLine("[{0}]", string.Join(", ", array3));
        }

    }
}
