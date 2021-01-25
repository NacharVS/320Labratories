using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laboratories320.Seydametov.Task_Parallel
{
    class Paral
    {
        public static void Main1()
        {
            Parallel.Invoke(sum, mul, div);
        }
        static void sum()
        {
            Thread.Sleep(2000);
            Console.WriteLine("id " + Task.CurrentId);
            Console.WriteLine($"res{5 + 9}");
        }

        static void mul()
        {
            Console.WriteLine(5 * 9);

        }

        static void div()
        {
            Console.WriteLine();
        }
    }
}
