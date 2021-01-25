using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Hamatullin._6praktik
{
    class Player
    {
        public string UserName { get; set; }
        public int DayOfBirth { get; set; }
        public int FinishedMatches { get; set; }
        public int Victories { get; set; }
        public int GamePoints { get; set; }
        public Player(string UserName,int DayOfBirth,int FinishedMatches,int Victories,int GamePoints)
        {
            this.UserName = UserName;
            this.DayOfBirth = DayOfBirth;
            this.FinishedMatches = FinishedMatches;
            this.Victories = Victories;
            this.GamePoints = GamePoints;
        }
    }
    class GameCreationStart
    {
        static Player player1 = new Player("Vasyan", 2002, 10, 5, 1000);
        static Player player2 = new Player("Imilkin", 2000, 29, 10, 3203);
        static Player player3 = new Player("KiamchikKruts", 1999, 50, 30, 7203);
        public string Search(Player player)
        {
            return player.UserName;
        }
        public static string SearchByName()
        {
            ParallelLoopResult result = Parallel.ForEach<Player>(new List<Player>() { player1, player2, player3 }, Search);

        }
        
    }
}
