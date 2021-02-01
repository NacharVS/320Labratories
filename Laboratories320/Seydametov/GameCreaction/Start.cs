using Laboratories320.Seydametov.GameCreaction.Class;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Seydametov.GameCreaction
{
    class Start
    {
        public static User[] users_array;

        public void start()
        {
            User us1 = new User("Vitala", 10, 5, 1000, DateTime.Today);
            User us2 = new User("Eldar", 30, 5, 1, DateTime.Today);
            User us3 = new User("Fanil", 100, 5, 10000, DateTime.Today);
            users_array = new User[] { us1, us2, us3 };
            SearchName("Vitala");
            GameStat();
        }

        public static void SearchName(string name)
        {
            User User1 = null;
            Parallel.ForEach(users_array, (User user) => {
                if (user.Name == name)
                    User1 = user;
            });
            Console.WriteLine("Name " + User1.Name + " Finished Matches " + User1.FinishedMatches + " Victories " + User1.Victories);
        }

        public static void GameStat()
        {
            int playedMatchesQuantity = 0;
            Parallel.ForEach(users_array, (User user) => {
                playedMatchesQuantity += user.FinishedMatches;
            });
            Console.WriteLine("Matches quantity = " + playedMatchesQuantity);
        }
    }
}
