using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Sindryakov.GameCreationStartLesson
{
    class Player
    {
        //описание класса Player
        public string UserName { get; set; }
        public DateTime DayOfBirth { get; set; }
        public int FinishedMatches { get; set; }
        public int Victories { get; set; }
        public int GamePoints { get; set; }
        //конструктор 
        public Player(string userName, DateTime dayOfBirth, int finishedMatches, int victories, int gamePoints)
        {
            this.UserName = userName;
            this.DayOfBirth = dayOfBirth;
            this.FinishedMatches = finishedMatches;
            this.Victories = victories;
            this.GamePoints = gamePoints;
        }
    }
}
