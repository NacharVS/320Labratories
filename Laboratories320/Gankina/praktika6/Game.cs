using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laboratories320.Gankina.praktika6
{
    class Game
    {
        private string userName;
        public DateTime birthday;
        public int completedMatches;
        public int wins;
        public int gamePoints;

        List<Game> users = new List<Game> { };
        public string UserName { get; set; }
        public DateTime Birthday { get; set; }
        public int CompletedMatches { get; set; }
        public int Wins { get; set; }
        public int GamePoints { get; set; }



    }
}
