using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Shigapov.Task3
{
    class ThreadLocker
    {
        public static int[] array1 = new int[10];
        public static int[] array2 = new int[10];
        public static int[] array3 = new int[10];

        static object SumLocker = new object();
        static object ResultLocker = new object();

        public static void BaseThread()
        {
            Thread thread1 = new Thread(new ThreadStart(Rnd));
            Thread thread2 = new Thread(new ThreadStart(Sum));
            thread1.Start();
            Thread.Sleep(10);
            thread2.Start();
            Console.WriteLine("[{0}]", string.Join(", ", array1));
            Console.WriteLine("[{0}]", string.Join(", ", array2));
            Console.WriteLine("[{0}]", string.Join(", ", array3));
        } 

        public static void Sum()
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



        public static void Rnd()
        {
            lock (SumLocker)
            {
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    array1[i] = rnd.Next(-10, 10);
                    array2[i] = rnd.Next(-10, 10);
                }
                Console.WriteLine("Generating");
            }
        }

    }
}
