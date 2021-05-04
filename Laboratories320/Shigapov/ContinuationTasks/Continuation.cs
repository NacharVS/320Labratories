using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Shigapov.ContinuationTasks
{
    class Continuation
    {
        public static int Composit = 1;
        public static void Сomposition(int[] array)
        {
            for (int i = 0; i < 20; i++)
            {
                Composit = Composit*array[i];
            }
            Console.WriteLine("Сomposition: " + Composit);
        }

        public static void Even()
        {
            string comp = Composit.ToString();
            string EvenDigits = "";
            for(int i = 0; i < comp.Length; i++)
            {
                if (comp[i]%2 == 0)
                {
                    EvenDigits += comp[i];
                }
            }
            Console.WriteLine("Even digits: "+EvenDigits);
        }

    }
}
