using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Cherginova.GameCreationStart
{
    class User
    {
        public string Name { get; set; }
        public DateTime DayOfBirth { get; set; }
        public int FinishedMatches { get; set; }
        public int Victories { get; set; }
        public double GamePoints { get; set; }
        public string SearchByName(string s)
        {
            return s;
        }
        public int GameStat(int i)
        {
            return i;
        }
    }
}
