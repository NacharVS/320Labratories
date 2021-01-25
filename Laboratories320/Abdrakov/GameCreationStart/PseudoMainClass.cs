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
            users = new User[] { new User("Igor", new DateTime(2002, 2, 1)), new User("Vitala", new DateTime(2004, 11, 23)), 
                new User("Alesha", new DateTime(2000, 2, 21)), new User("Ukrop", new DateTime(2002, 4, 2)), new User("Shigapov", new DateTime(2003, 10, 14)),
                new User("Rail", new DateTime(2001, 1, 18)), new User("Ilham", new DateTime(2004, 4, 11)), new User("Fanil", new DateTime(2002, 12, 8))};
        }

        // Returns player's stats
        public static int SearchByName(string name)
        {

        }
    }
}
