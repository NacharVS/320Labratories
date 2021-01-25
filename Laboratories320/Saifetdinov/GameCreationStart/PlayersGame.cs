using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Saifetdinov.GameCreationStart
{
    class PlayersGame
    {
            public static GameCreation player1 = new GameCreation(1, "Джордж", "15-02-2002", 2, 1, 500);
            public static GameCreation player2 = new GameCreation(2, "Коржика", "14-08-2001", 5, 3, 1000);
            public static GameCreation player3 = new GameCreation(3, "Зрек", "20-25-2006", 7, 4, 1500);
            public static GameCreation player4 = new GameCreation(4, "Соник", "01-05-2004", 1, 0, 10);
            public static GameCreation player5 = new GameCreation(5, "Оскар", "03-07-2005", 6, 2, 140);

            public static List<GameCreation> players = new List<GameCreation> { player1, player2, player3, player4, player5 };

            public static void SearchByName()
            {
                Parallel.ForEach(players, s => s.GetAName());
            }
            public static void ReturnAllStats()
            {
                Parallel.ForEach(players, s => s.StatisticsGame());
            }

    }
}
