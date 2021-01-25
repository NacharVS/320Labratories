using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Shigapov.GameCreationStart
{
    class PlayingField
    {
        public static UserGame[] players;

        public static void Gamers()
        {
            UserGame user1 = new UserGame("Lord", new DateTime(01, 03, 01), 10, 5, 40);
            UserGame user2 = new UserGame("Ivan", new DateTime(03, 02, 01), 11, 10, 37);
            UserGame user3 = new UserGame("Alex", new DateTime(19, 08, 02), 12, 8, 35);
            players = new UserGame[] { user1, user2, user3 };
        }

        public static void SearchByName(string Name)
        {
            for (int i = 0; i < players.Length; i++)
            {

            }
        }

    }
}
