using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Abdrakov.GameCreationStart
{
    public class User : IStat
    {
        public string userName { get; private set; }
        public DateTime dayOfBirth { get; private set; }
        public int finishedMatches { get; private set; }
        public int victories { get; private set; }
        public int gamePoints { get; private set; }

        public User(string userNameIn, DateTime dayOfBirthIn, int finishedMatchesIn, int victoriesIn, int gamePointsIn)
        {
            this.dayOfBirth = dayOfBirthIn;
            this.userName = userNameIn;
            this.finishedMatches = finishedMatchesIn;
            this.victories = victoriesIn;
            this.gamePoints = gamePointsIn;
        }

        public int GameStat()
        {
            return finishedMatches;
        }
    }
}
