using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Zakirov._6GameCreatStart
{
    class GameCreationStart
    {
        public string UserName { get; set; }
        public string DayOfBirth { get; set; }
        public int FinishedMatches { get; set; }
        public int Victories { get; set; }
        public int GamePoints { get; set; }

        public GameCreationStart(string UserName, string DayOfBirth, int FinishedMatches, int Victories, int GamePoints)
        {
            this.UserName = UserName;
            this.DayOfBirth = DayOfBirth;
            this.FinishedMatches = FinishedMatches;
            this.Victories = Victories;
            this.GamePoints = GamePoints;
        }

       class User
        {
            GameCreationStart user1 = new GameCreationStart("Евгений", "20.01.2001", 4, 2, 61);
            GameCreationStart user2 = new GameCreationStart("Семён", "13.12.2003", 6, 4, 43);
            GameCreationStart user3 = new GameCreationStart("Григорий", "05.05.2000", 7, 3, 87);
            GameCreationStart user4 = new GameCreationStart("Александр", "18.03.1999", 5, 4, 42);
            GameCreationStart user5 = new GameCreationStart("Игорь", "28.08.2002", 4, 4, 100);
        }
    }
}
