using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Gaifullin.GameCreationStart
{
    class GameCreationStart
    {
        public string UserName { get; set; }
        public DateTime DayOfBirth { get; set; }
        public int FinishedMatches { get; set; }
        public int Victories { get; set; }
        public int GamePoints { get; set; }

        public GameCreationStart(string name, DateTime BirthDate, int finishedMatches, int victories, int gamePoints)
        {
            this.UserName = name;
            this.DayOfBirth = BirthDate;
            this.FinishedMatches = finishedMatches;
            this.Victories = victories;
            this.GamePoints = gamePoints;
        }

        public int GetStat()
        {
            return FinishedMatches;
        }

    }
}
 