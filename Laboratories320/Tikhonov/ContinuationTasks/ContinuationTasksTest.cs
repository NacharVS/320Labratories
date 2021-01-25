using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laboratories320.Tikhonov.ContinuationTasks
{
    class ContinuationTasksTest
    {
        public static long number = 1;
        public static void Tasks()
        {
            int[] Arr = new int[20];
            Task taskArrGen = Task.Factory.StartNew(() =>
            {
                arrGen(Arr);
            });
            Task taskMultiply = taskArrGen.ContinueWith(test => productOfElements(Arr));
            Task taskGetEven = taskMultiply.ContinueWith(test2 => getEven());
            taskGetEven.Wait();
        }
        private static void productOfElements(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {

                number *= Arr[i];

            }
            Console.WriteLine(number);

        }

        private static void getEven()
        {
            char[] charArr = number.ToString().ToCharArray();
            foreach (char i in charArr)
 
            {
                if ((i - '0')%2 == 0)
                {
                    Console.Write(i);
                }
            }
        }

        private static void arrGen(int[] Arr)
        {
            Random rand = new Random();
            
                for (int i = 0; i < Arr.Length; i++)
                {
                    Arr[i] = rand.Next(1,10);
                }
                Console.WriteLine("[{0}]", string.Join(", ", Arr));



            
        }
    }
}
