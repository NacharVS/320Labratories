using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Laboratories320.Davletkirova.GameCreationStart
{
    class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string DayOfBirth { get; set; }
        public int FinishedMatches { get; set; }
        public int Victories { get; set; }
        public int GamePoints { get; set; }

        public User(int id, string userName, string dayOfBirth, int finishedMatchees, int victories, int gamePoints)
        {
            this.Id = id;
            this.UserName = userName;
            this.DayOfBirth = dayOfBirth;
            this.FinishedMatches = finishedMatchees;
            this.Victories = victories;
            this.GamePoints = gamePoints;
        }
        public void GetAName()
        {
            Console.WriteLine($"Id player - {Id} name player - {UserName}");
        }
        public void StatisticsGame()
        {
            Console.WriteLine($"Id player - {Id}, FinishedMatches - {FinishedMatches}, Victories - {Victories}, Game Points - {GamePoints}");
        }
    }
}
