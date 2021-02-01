using Laboratories320.Seydametov.GameCreaction.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Seydametov.GameCreaction.Class
{
    class User : IUserName, IDayOfBirth, IFinishedMatches, IVictories, IGamePoints
    {
        private string UserName = "";
        private int UserFinishedMatches = 0;
        private int UserVictories = 0;
        private long UserGamePoints = 0;
        private DateTime UserDayOfBirth = new DateTime();

        public User(string UserName, int UserFinishedMatches, int UserVictories, long UserGamePoints, DateTime UserDayOfBirth)
        {
            this.UserName = UserName;
            this.UserFinishedMatches = UserFinishedMatches;
            this.UserVictories = UserVictories;
            this.UserGamePoints = UserGamePoints;
            this.UserDayOfBirth = UserDayOfBirth;
        }
        public string Name { get => UserName; set => UserName = value; }
        public int FinishedMatches { get => UserFinishedMatches; set => UserFinishedMatches = value; }
        public int Victories { get => UserVictories; set => UserVictories = value; }
        public long GamePoints { get => UserGamePoints; set => UserGamePoints = value; }
        public DateTime DayOfBirth { get => UserDayOfBirth; set => UserDayOfBirth = value; }

    }
}
