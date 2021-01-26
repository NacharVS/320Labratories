using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.tasks
{
    class Tasks2
    {

        static int[] arr = new int[20];
        static int comp = 1;

        static void MainTwo()
        {

            Task task1 = new Task(() => Random_Ar());
            task1.Start();

            Task task2 = task1.ContinueWith((task1) => Comp());
            task2.Wait();

            Task task3 = task2.ContinueWith((task2) => EvenNum());
            task3.Wait();
        }

        static void Random_Ar()
        {
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 4);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void Comp()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                comp = arr[i] * comp;
            }

            Console.WriteLine();
            Console.WriteLine("Произведение: " + comp);
        }

        static void EvenNum()
        {
            int comp2;
            Console.Write("Четные числа: ");

            while (comp > 9)
            {

                comp2 = comp % 10;
                if ((comp2 % 2 == 0) && (comp2 != 0))
                {
                    Console.Write(comp2 + " ");
                }

                comp = comp / 10;
            }

            if ((comp % 2 == 0) && (comp != 0))
            {
                Console.Write(comp + " ");
            }
        }

    }
}
