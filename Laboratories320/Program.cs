using System;
using Laboratories320.Zakirov._2Thread;
using Laboratories320.Zakirov._3ThreadLocker;
using Laboratories320.Zakirov._4ThreadTask;
using Laboratories320.Zakirov._5ContinuationTasks;
using Laboratories320.Zakirov._6GameCreatStart;
using System.Threading.Tasks;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            User.SearchByName("Семён");
            User.GameStat();
        }
    }
}
