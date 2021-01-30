using System;
using System.Threading;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(Sort));
            thread1.Start();

            Thread thread2 = new Thread(new ThreadStart(Max));
            thread2.Start();

            Thread thread3 = new Thread(new ThreadStart(Sum));
            thread3.Start();

        }


        public static void Sum()
        {
            int[] n = { 12, 25, 3, -2, 0 };
            int k = 0;
            for (int i = 0; i < n.Length; i++)
            {
                k += n[i];
              
            }
            Console.WriteLine($"Сумма элементов в массиве = {k}");
        }
        public static void Sort()
        {
            int[] n = { 91, 3, -2, 5, 26, -4 };
            Array.Sort(n);
            foreach (int a in n)
            {
                Console.Write($"{a} ");

            }
            Console.WriteLine();

        }
        public static void Max()
        {
            int max = 0;
            int[] n = { 1, 20, 31, 4, 52 };

            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] > max)
                {
                    max = n[i];
                }
            }
            Console.WriteLine($"Макс элемент в массиве = {max}");
        }

    }
}
