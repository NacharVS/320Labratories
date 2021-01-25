using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Zakirov._6GameCreatStart
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
            public static GameCreationStart user1 = new GameCreationStart("Евгений", "20.01.2001", 4, 2, 61);
            public static GameCreationStart user2 = new GameCreationStart("Семён", "13.12.2003", 6, 4, 43);
            public static GameCreationStart user3 = new GameCreationStart("Григорий", "05.05.2000", 7, 3, 87);
            public static GameCreationStart user4 = new GameCreationStart("Александр", "18.03.1999", 5, 4, 42);
            public static GameCreationStart user5 = new GameCreationStart("Игорь", "28.08.2002", 4, 4, 100);

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

