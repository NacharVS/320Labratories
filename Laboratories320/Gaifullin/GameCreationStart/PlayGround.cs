using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Gaifullin.GameCreationStart
{
    class PlayGround
    {
        public static GameCreationStart[] gamers;

        public static void Gamers()
        {
            GameCreationStart user1 = new GameCreationStart("Robby", new DateTime(11, 11, 11), 11,11, 11);
            GameCreationStart user2 = new GameCreationStart("Miguel", new DateTime(05, 05, 05), 05, 05, 05);
            GameCreationStart user3 = new GameCreationStart("Hawk", new DateTime(07, 07, 07), 07, 07, 07);
            gamers = new GameCreationStart[] { user1, user2, user3 };
        }

        public static void SearchByName(string Name)
        {
            for (int i = 0; i < gamers.Length; i++)
            {

            }
        }
    }
}
