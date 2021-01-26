using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Laboratories320.Kiyamov._6Praktika;

namespace Laboratories320.Kiyamov._6Praktika
{
    class GameCreationStart
    {
        public string UserName { get; set; }
        public DateTime DayOfBirth { get; set; }
        public int Victories { get; set; }
        public int GamePoints { get; set; }
        public int FinishedMatches { get; set; }
    


    public GameCreationStart(string UserName, DateTime DayOfBirth, int Victories, int GamePoints, int FinishedMatches)
    {
        this.UserName = UserName;
        this.DayOfBirth = DayOfBirth;
        this.Victories = Victories;
        this.GamePoints = GamePoints;
        this.FinishedMatches = FinishedMatches;


        }
    public class Player
    {
        Player Player1 = new ("", new DateTime(2000, 2, 4), 28, 25, 75);



        }


}
