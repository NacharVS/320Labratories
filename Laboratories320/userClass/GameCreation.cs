using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laboratories320.userClass
{
    class GameCreation
    {

        public static List<User> users;

        public static void Gamers()
        {
            User u1 = new User(1,"Andrew", new DateTime(05, 03, 99), 19, 15, 40);
            User u2 = new User(2,"Herg", new DateTime(09, 07, 01), 10, 10, 17);
            User u3 = new User(3,"Tom", new DateTime(9, 02, 02), 32, 19, 45);
            users = new List<User> { u1, u2, u3 };
            SearchByName("Tom");
            Parallel.ForEach(users, GameStat);
        }

        public static void SearchByName(string Name)
        {
            foreach (var item in users)
            {
                if (item.Name == Name)
                {
                    Console.WriteLine("Name: " + item.Name+"\nDayOfBirth: " + item.DayOfBirth+"\nFinishedMatches: " + 
                        item.FinishedMatches+"\nVictories: " + item.Victories+"\nGamePoints: " + item.GamePoints);
                }
            }
        }

        public static void GameStat(User u)
        {
            Console.WriteLine("Name: " + u.Name+"\nFinishedMatches: " + u.FinishedMatches);
        }
    }
}
