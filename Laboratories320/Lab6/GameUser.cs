using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Lab6
{
    class GameUser
    {
        string userName;
        DateTime dayOfBirth;
        int finishedMatches;
        int victories;
        double point;
        List<GameUser> gameUsers = new List<GameUser> { };

        string UserName { get => userName; set => userName = value; }
        DateTime DayOfBirth { get => dayOfBirth; set => dayOfBirth = value; }
        int FinishedMatches { get => finishedMatches; set => finishedMatches = value; }
        int Victories { get => victories; set => victories = value; }
        double Point { get => point; set => point = value; }
        public GameUser(string userName, DateTime dayOfBirth, int finishedMatches, int victories, double point)
        {
            this.userName = userName;
            this.dayOfBirth = dayOfBirth;
            this.finishedMatches = finishedMatches;
            this.victories = victories;
            this.point = point;
            gameUsers.Add(this);
        }

        public void SearchByName(string name)
        {
            Parallel.ForEach(gameUsers, user =>
            {
                if (user.UserName == name)
                {
                    Console.WriteLine("Имя пользователя: {0} День рождения: {1} Кол-во завершенных матчей: {2} Кол-во побед: {3} Кол-во очков: {5}", user.UserName, user.DayOfBirth, user.FinishedMatches, user.Victories, user.Point);
                }
            });


        }
    }
}

