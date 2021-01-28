using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Volkov._6_practice
{
    class GameCreationStart
    {
        public string UserName { get; set; }
        public string DayOfBirth { get; set; }
        public int FinishedMatches { get; set; }
        public int Victories { get; set; }
        public int GamePoints { get; set; }

        public GameCreationStart(string UserName, string DayOfBirth, int FinishedMatches, int Victories, int GamePoints)
        {
            this.UserName = UserName;
            this.DayOfBirth = DayOfBirth;
            this.FinishedMatches = FinishedMatches;
            this.Victories = Victories;
            this.GamePoints = GamePoints;
        }

        public void GetName(string name)
        {
            if (name == UserName)
            {
                Console.WriteLine("Имя пользователя: " + UserName);
            }
            else
            {
                Console.WriteLine("Пользователь не найден");
            }
        }

        public void GetStatistic()
        {
            Console.WriteLine("Имя пользователя: {0} \n Количество матчей: {1} \n Количество побед: {2} \n Количество очков: {3}",
                UserName, FinishedMatches, Victories, GamePoints);
        }
    }
    class User
    {
        public static GameCreationStart user1 = new GameCreationStart("Evgen", "09.01.2002", 4, 2, 61);
        public static GameCreationStart user2 = new GameCreationStart("Alex", "24.12.2002", 6, 4, 43);
        public static GameCreationStart user3 = new GameCreationStart("Andrew", "01.10.2002", 7, 3, 87);
        public static GameCreationStart user4 = new GameCreationStart("Ruslan", "18.06.2002", 5, 4, 42);
        public static GameCreationStart user5 = new GameCreationStart("Kirecb", "24.05.2002", 4, 4, 100);

        public static List<GameCreationStart> users = new List<GameCreationStart> { user1, user2, user3, user4, user5 };

        public static void SearchByName(string name)
        {
            Parallel.ForEach(users, u => u.GetName(name));
        }

        public static void GameStat()
        {
            Parallel.ForEach(users, u => u.GetStatistic());
        }
    }
}





