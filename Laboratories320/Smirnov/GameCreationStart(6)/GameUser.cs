using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Smirnov.GameCreationStart_6_
{
    class GameUser
    {
        public string Name { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public int FinishedMatches { get; set; }
        public int Victories { get; set; }
        public int GamePoints { get; set; }

        public GameUser(string name, DateTime dateofbirth, int finishedmatches, int victories, int gamepoints)
        {
            Name = name;
            DateOfBirth = dateofbirth;
            FinishedMatches = finishedmatches;
            Victories = victories;
            GamePoints = gamepoints;
        }
    }
}
