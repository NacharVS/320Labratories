using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Tikhonov.GameCreationStart
{
    class GameUsers : Ifields
    {


        public GameUsers(string userNasme, int finishedMatches, int victories, int gamePoints)
        {
            this.UserName = userNasme
            //this.DayOfBirth = dayOfBirth
            this.FinishedMatches = finishedMatches
            this.Victories = victories
            this.GamePoints = gamePoints;
        }
        public string UserName { get { return (userName); } set { userName = value; } }
        //public DateTime DayOfBirth { get { return (dayOfBirth); } set { dayOfBirth = value; } }
        public int FinishedMatches { get { return (finishedMatches); } set { finishedMatches = value; } }
        public int Victories { get { return (victories); } set { victories = value; } }
        public int GamePoints { get { return (gamePoints); } set { gamePoints = value; } }
    }
}
