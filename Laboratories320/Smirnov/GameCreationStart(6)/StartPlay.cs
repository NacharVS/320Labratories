using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Smirnov.GameCreationStart_6_
{
    static class StartPlay
    {
        static List<GameUser> players;
        public static void GameUsers()
        {
            GameUser alex = new GameUser("Alex", new DateTime(2002, 12, 7), 30, 10, 30);
            GameUser rail = new GameUser("Rail", new DateTime(2000, 2, 4), 28, 25, 75);
            GameUser simple = new GameUser("Simple", new DateTime(1995, 2, 7), 23, 20, 60);
            GameUser electronic = new GameUser("Electronic", new DateTime(1994, 12, 23), 4, 4, 12);
            GameUser evgen4ik = new GameUser("Evgen4ik", new DateTime(2003, 3, 3), 11, 10, 30);
            GameUser zeus = new GameUser("Zeus", new DateTime(1999, 2, 21), 12, 12, 36);
            players = new List<GameUser> { alex, rail, simple, electronic, evgen4ik, zeus };
            Parallel.ForEach<string>(new List<string> { "Alex", "Rail", "Simple", "Electronic", "Evgen4ik", "Zeus" }, SearchByName);
            Parallel.ForEach(players, GameStat);
        }

        public static void SearchByName(string name)
        {
            foreach (var item in players)
            {
                if (item.Name == name)
                {
                    Console.WriteLine($"Name: {item.Name} \nDayOfBirth: { item.DateOfBirth} \n" +
                        $"FinishedMatches: {item.FinishedMatches} \nVictories: {item.Victories} \nGamePoints: {item.GamePoints}");
                }
            }
        }

        public static void GameStat(GameUser gameUser)
        {
            Console.WriteLine($"User name: {gameUser.Name} \nDay of birth: {gameUser.DateOfBirth} \n" +
                $"Finished matches: {gameUser.FinishedMatches} \nVictories: {gameUser.Victories} \nGame points: " +
                $"{gameUser.GamePoints}");
        }
    }
}
