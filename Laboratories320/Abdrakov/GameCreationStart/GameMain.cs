using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laboratories320.Abdrakov.GameCreationStart
{
    public static class GameMain
    {
        public static User[] users;
        public static void StartGame()
        {
            User user1 = new User("Igor", new DateTime(2002, 2, 1), 13, 3, 1400);
            User user2 = new User("Vitala", new DateTime(2004, 11, 23), 42, 12, 3200);
            User user3 = new User("Alesha", new DateTime(2000, 2, 21), 2, 0, 100);
            User user4 = new User("Ukrop", new DateTime(2002, 4, 2), 17, 15, 2500);
            User user5 = new User("Shigapov", new DateTime(2003, 10, 14), 33, 20, 2200);
            User user6 = new User("Rail", new DateTime(2001, 1, 18), 4, 1, 400);
            User user7 = new User("Ilham", new DateTime(2004, 4, 11), 0, 0, 0);
            User user8 = new User("Fanil", new DateTime(2002, 12, 8), 41, 22, 1800);
            users = new User[] { user1, user2, user3, user4, user5, user6, user7, user8};

            string userName = "Fanil";
            int searchResult = SearchByName(userName);
            Console.WriteLine("User " + userName + " has stats: " + searchResult);
            Console.WriteLine();

            int sumOfPlayedGames = GameStat();
            Console.WriteLine();
            Console.WriteLine("All matches quantity: " + sumOfPlayedGames);
        }

        // Returns player's stats
        public static int SearchByName(string name)
        {
            User neededUser = null;
            Parallel.ForEach(users, (User user) => {
                if (user.userName == name)
                    neededUser = user;
            });
            if (neededUser is object)
                return neededUser.finishedMatches;
            return -1;
        }

        public static int GameStat()
        {
            int sumOfPlayedGames = 0;
            object locker = new object();
            Parallel.ForEach(users, (User user) => {
                Console.WriteLine("User: " + user.userName + ", FinishedMatches: " + user.finishedMatches);
                lock (locker) sumOfPlayedGames += user.finishedMatches;
            });
            return sumOfPlayedGames;
        }
    }
}
