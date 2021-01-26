using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Musin.GameCreatStart
{
    class GameCreationStart
    {
        public string Name { get; set; }
        public string DayBirth { get; set; }
        public int FinishedMatches { get; set; }
        public int Victories { get; set; }
        public int Points { get; set; }

        public GameCreationStart(string Name, string DayBirth, int FinishedMatches, int Victories, int Points)
        {
            this.Name = Name;
            this.DayBirth = DayBirth;
            this.FinishedMatches = FinishedMatches;
            this.Victories = Victories;
            this.Points = Points;
        }
        public void GetName(string name)
        {
            if (name == Name)
            {
                Console.WriteLine("Пользователь: " + Name);
            }
            else
            {
                Console.WriteLine("Пользователь не найден");
            }
        }

        public void GetStats()
        {
            Console.WriteLine("Пользователь: {0} \n Кол-во матчей: {1} \n Кол-во побед: {2} \n Кол-во очков: {3}",
                Name, FinishedMatches, Victories, Points);
        }
    }
    class User
    {
            public static GameCreationStart user1 = new GameCreationStart("Артур", "13.04.2004", 4, 3, 59);
            public static GameCreationStart user2 = new GameCreationStart("Валера", "10.11.2002", 5, 2, 46);
            public static GameCreationStart user3 = new GameCreationStart("Настя", "15.06.2003", 7, 4, 85);
            public static GameCreationStart user4 = new GameCreationStart("Юрий", "17.07.1998", 6, 3, 43);
            public static GameCreationStart user5 = new GameCreationStart("Петр", "25.09.2001", 3, 3, 90);

            public static List<GameCreationStart> users = new List<GameCreationStart> { user1, user2, user3, user4, user5 };

            public static void SearchName(string name)
            {
                Parallel.ForEach(users, u => u.GetName(name));
            }

            public static void GameStat()
            {
                Parallel.ForEach(users, u => u.GetStats());
            }
        }
    }
