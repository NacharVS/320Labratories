using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Laboratories320.Kiyamov._6Praktika;

namespace Laboratories320.Kiyamov._6Praktika
{
    class Player
    {
        public string UserName { get; set; }
        public int DayOfBirth { get; set; }
        public int Victories { get; set; }
        public int GamePoints { get; set; }
        public int FinishedMatches { get; set; }


        public Player(string UserName, int DayOfBirth, int Victories, int GamePoints, int FinishedMatches)
        {
            this.UserName = UserName;
            this.DayOfBirth = DayOfBirth;
            this.Victories = Victories;
            this.GamePoints = GamePoints;
            this.FinishedMatches = FinishedMatches;

        }
        public void Search(string name)
        {
            if (name == UserName)
            {
                Console.WriteLine($": {UserName}");
            }
        }
    }
        class CreatePlayerStart
        {
            static Player Marsel = new Player("Marsel", 2001, 19, 12, 1726);
            static Player Ilham = new Player("Ilham", 2004, 9, 9, 2972);
            static Player Kamil = new Player("Kamil", 1859, 5, 7, 5145);
            static List<Player> players = new List<Player> { Marsel, Ilham, Kamil };
            public static void SearchByName(string UserName)
            {
                Parallel.ForEach(players, s => s.Search(UserName));

            }
        }
    }


    

        
      
    


