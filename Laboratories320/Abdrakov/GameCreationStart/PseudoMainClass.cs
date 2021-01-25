using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Abdrakov.GameCreationStart
{
    public static class PseudoMainClass
    {
        public static User[] users;
        public static void PseudoMain()
        {
            User user1 = new User("Igor", new DateTime(2002, 2, 1));
            User user2 = new User("Vitala", new DateTime(2004, 11, 23));
            User user3 = new User("Alesha", new DateTime(2000, 2, 21));
            User user4 = new User("Ukrop", new DateTime(2002, 4, 2));
            User user5 = new User("Shigapov", new DateTime(2003, 10, 14));
            User user6 = new User("Rail", new DateTime(2001, 1, 18));
            User user7 = new User("Ilham", new DateTime(2004, 4, 11));
            User user8 = new User("Fanil", new DateTime(2002, 12, 8));
            users = new User[] { user1, user2, user3, user4, user5, user6, user7, user8};
            SearchByName("Alesha");
        }

        // Returns player's stats
        public static int SearchByName(string name)
        {

        }
    }
}
