using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Musin.GameCreatStart
{
    class GameCreationStart
    {
        public string UserName { get; set; }
        public DateTime DayOfBirth { get; set; }
        public int FinishedMatches { get; set; }
        public int Victories { get; set; }
        public int GamePoints { get; set; }

        public GameCreationStart(string UserName, DateTime DayOfBirth, int FinishedMatches, int Victories, int GamePoints)
        {
            this.UserName = UserName;
            this.DayOfBirth = DayOfBirth;
            this.FinishedMatches = FinishedMatches;
            this.Victories = Victories;
            this.GamePoints = GamePoints;
        }
    }
}
