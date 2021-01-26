using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.userClass
{
    class User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DayOfBirth { get; set; }
        public int FinishedMatches { get; set; }
        public int Victories { get; set; }
        public int GamePoints { get; set; }
        public User(int id, string Name, DateTime dayOfBirth, int finishedMatchees, int victories, int gamePoints)
        {
            this.Id = id;
            this.Name = Name;
            this.DayOfBirth = dayOfBirth;
            this.FinishedMatches = finishedMatchees;
            this.Victories = victories;
            this.GamePoints = gamePoints;
        }


    }
}

