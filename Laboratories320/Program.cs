using Laboratories320.Mazitova.Pr3;
using Laboratories320.Mazitova.Pr4;
using System;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Leave hope behind all who enters here...");
            //Console.WriteLine();

            //ThreadLocker thr = new ThreadLocker();
            //thr.Start();

            //ThreadLockerTask task = new ThreadLockerTask();
            //task.Start();

            Hero hero = new Hero
            {
                HeroName = "Пирожок",
                Health = 100
            };

            //Hero.HeroInsert(hero).GetAwaiter().GetResult();

            Hero hero1 = new Hero
            {
                HeroName = "Зайка",
                Health = 120
            };
            //Hero.HeroInsert(hero1).GetAwaiter().GetResult();
            Hero.HeroNameResault("Cумса", hero1).GetAwaiter().GetResult();
        }
    }
}
