
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Laboratories320.threads
{
    class Threads
    {
        static double[] arr = { 1, 8, 3, 9, 5 };
        static double sum = 0;
        static double max;
        static void MainTwo()
        {

            Thread t = new Thread(Sum);
            t.Start();
            Thread t1 = new Thread(Max);
            t1.Start();
            Thread t2 = new Thread(Sort);
            t2.Start();

        }
        static void Sum()
        {


            for (int i = 0; i < arr.Length; i++)
            {

                sum = sum + arr[i];
            }
            Console.WriteLine("Сумма= " + sum);
        }
        static void Max()
        {

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Максимальное число= " + max);
        }
        static void Sort()
        {
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}
