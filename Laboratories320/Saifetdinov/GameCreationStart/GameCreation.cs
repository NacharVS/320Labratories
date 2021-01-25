using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Saifetdinov.GameCreationStart
{
    class GameCreation
    {
        public string UserName { get; set; }
        public string DayOfBirth { get; set; }
        public int FinishedMatches { get; set; }
        public int Victories { get; set; }
        public int GamePoints { get; set; }

        public GameCreation(string userName, string dayOfBirth, int finishedMatchees, int victories, int gamePoints)
        {
            this.UserName = userName;
            this.DayOfBirth = dayOfBirth;
            this.FinishedMatches = finishedMatchees;
            this.Victories = victories;
            this.GamePoints = gamePoints;
        }
        
    }
    class Player
    {
        GameCreation player1 = new GameCreation("Джордж", "15-02-2002", 2, 1, 500);
        GameCreation player2 = new GameCreation("Коржика", "14-08-2001", 5, 3, 1000);
        GameCreation player3 = new GameCreation("Зрек", "20-25-2006", 7, 4, 1500);
        GameCreation player4 = new GameCreation("Соник", "01-05-2004", 1, 0, 10);
        GameCreation player5 = new GameCreation("Оскар", "03-07-2005", 6, 2, 140);
    }

    class Inplement
    {
        public static void SearchByName()
        {

        }
    }
}
