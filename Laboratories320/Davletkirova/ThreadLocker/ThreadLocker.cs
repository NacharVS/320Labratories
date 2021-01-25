using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Mazitova.Pr3
{
    class ThreadLocker
    {
        static int[] arr1 = new int[10];
        static int[] arr2 = new int[10];
        static int[] arr3 = new int[10];

        static object locker = new object();
        public void Start()
        {
            Thread GenThr = new Thread(GetArray);
            Thread SumThr = new Thread(Sum);

            GenThr.Start();
            Thread.Sleep(1000);
            SumThr.Start();
            Thread.Sleep(2000);

        }
        public void GetArray()
        {
            lock (locker)
            {
                Console.WriteLine("First array");
                Random random = new Random();
                for (int i = 0; i < arr1.Length; i++)
                {
                    arr1[i] = random.Next(-100, 100);
                }

                foreach (var it in arr1)
                {
                    Console.WriteLine(it + " ");
                }
            }
            lock (locker)
            {
                
                Console.WriteLine("Second array");
                Random random = new Random();
                for (int i = 0; i < arr2.Length; i++)
                {
                    arr2[i] = random.Next(-100, 100);
                }

                foreach (var it in arr2)
                {
                    Console.WriteLine(it + " ");
                }
            }

        }
        

        public void Sum()
        {
            lock (locker)
            {
                
                Console.WriteLine("Sum arrays");
                for (int i = 0; i < arr1.Length && i < arr2.Length; i++)
                {
                    arr3[i] = arr1[1] + arr2[i];
                }

                foreach (var item in arr3)
                {
                    Console.WriteLine(item + " ");
                }
            }

        }
    }
}
