using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.task_25._01._21
{
    class User
    {
        string userName;
        DateTime dayOfBirth;
        int finishedMatches;
        int victories;
        int gamePoints;

        public string UserName { get { return userName; } set { this.userName = value; } }
        public DateTime DayOfBirth { get { return dayOfBirth; } set { this.dayOfBirth = value; } }
        public int FinishedMatches { get { return finishedMatches; } set { this.finishedMatches = value; } }
        public int Victories { get { return victories; } set { this.victories = value; } }
        public int GamePoints { get { return gamePoints; } set { this.gamePoints = value; } }

    }
}
