using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laboratories320.Shigapov.GameCreationStart
{
    class PlayingField
    {
        public static List<UserGame> players;

        public static void Gamers()
        {
            UserGame user1 = new UserGame("Lord", new DateTime(01, 03, 01), 10, 5, 40);
            UserGame user2 = new UserGame("Ivan", new DateTime(03, 02, 01), 11, 10, 37);
            UserGame user3 = new UserGame("Alex", new DateTime(19, 08, 02), 12, 8, 35);
            players = new List<UserGame> { user1, user2, user3 };
            Parallel.ForEach<string>(new List<string> { "Ivan", "Oleg", "Stepan" }, SearchByName);
            Parallel.ForEach(players, GetStat);
        }

        public static void SearchByName(string Name)
        {
            foreach(var item in players)
            {
                if(item.Name == Name)
                {
                    Console.WriteLine("Name: "+item.Name);
                    Console.WriteLine("DayOfBirth: "+item.DayOfBirth);
                    Console.WriteLine("FinishedMatches: "+item.FinishedMatches);
                    Console.WriteLine("Victories: " + item.Victories);
                    Console.WriteLine("GamePoints: " + item.GamePoints);
                }
            }
        }

        public static void GetStat(UserGame ug)
        {
            Console.WriteLine("Name: "+ ug.Name);
            Console.WriteLine("FinishedMatches: "+ug.FinishedMatches);
        }

    }
}
