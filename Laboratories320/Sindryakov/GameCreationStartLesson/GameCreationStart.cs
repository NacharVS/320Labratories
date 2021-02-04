using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laboratories320.Sindryakov.GameCreationStartLesson
{
    class GameCreationStart
    {
        public static List<Player> players;
        public static void Gamers()
        {
            //заполнил данные
            Player us1 = new Player("Vladimir", new DateTime(04, 04, 04), 4, 5, 77);
            Player us2 = new Player("Tanya", new DateTime(05, 05, 05), 5, 6, 88);
            Player us3 = new Player("Yolik", new DateTime(06, 06, 06), 6, 7, 99);
            Player us4 = new Player("Tosha", new DateTime(07, 07, 07), 7, 8, 66);
            Player us5 = new Player("Xamon", new DateTime(08, 08, 08), 8, 9, 55);
            //создал лист
            players = new List<Player> { us1, us2, us3, us4, us5 };
            //использование ForEach
            Parallel.ForEach<string>(new List<string> { "Vladimir", "Tanya", "Yolik", "Tosha", "Xamon" }, SearchByName);
            Parallel.ForEach(players, Statistic);
        }
        //поиск по имени
        public static void SearchByName(string userName)
        {
            foreach (var item in players)
            {
                if (item.UserName == userName)
                {
                    Console.WriteLine("Имя: " + item.UserName);
                    Console.WriteLine("Дата рождения: " + item.DayOfBirth);
                    Console.WriteLine("Завершенные матчи: " + item.FinishedMatches);
                    Console.WriteLine("Побед: " + item.Victories);
                    Console.WriteLine("Игровые очки: " + item.GamePoints);
                }
            }
        }
        //игровая статистика
        public static void Statistic(Player pl)
        {
            Console.WriteLine("Имя: " + pl.UserName);
            Console.WriteLine("Завершенные матчи: " + pl.FinishedMatches);
        }
    }
}
