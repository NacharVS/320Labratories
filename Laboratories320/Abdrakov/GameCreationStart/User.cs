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

        public User(string userNameIn, DateTime dayOfBirthIn)
        {
            this.dayOfBirth = dayOfBirthIn;
            this.userName = userNameIn;
        }

        public int GameStat()
        {
            return finishedMatches;
        }
    }
}
