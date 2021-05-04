using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Shigapov.Practic2
{
    class StartArray
    { 
        public static void BaseArr()
        {
            Arr array = new Arr();
            Thread thread1 = new Thread(Sum);
            Thread thread2 = new Thread(Max);
            Thread thread3 = new Thread(Sort);
            thread1.Start(array);
            thread2.Start(array);
            thread3.Start(array);

        }
        public static void Sum(object obj)
        {
            Arr a = (Arr)obj;
            int[] arr = a.array;
            int Sum = 0;
            foreach (int item in arr)
            {
                Sum += item;
            }
            Console.WriteLine("Sum: "+Sum);
        }

        public static void Max(object obj)
        {
            Arr a = (Arr)obj;
            int[] arr = a.array;
            int max = arr[0];
            for(int i =  1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Max: " + max);
        }

        public static void Sort(object obj)
        {
            Arr a = (Arr)obj;
            int[] arr =a.array;
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

    }
    class Arr 
    {
        public int[] array = { 10, 22, -10, 12, 45 };
    }
}
