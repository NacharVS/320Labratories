using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.task_25._01._21
{
    class GameSimulator
    {
        public static User SearchByName(string name, IEnumerable<User> collection)
        {
            foreach (var user in collection)
            {
                if (user.UserName == name)
                {
                    return user;
                }
            }
            return null;
        }

        public static void GameStat(User user)
        {
            Console.WriteLine($"Статистика игр для пользователя - {user.UserName}\nЗакончено матчей: {user.FinishedMatches}\nВыйграно матчей: {user.Victories}\nВсего очков набрано: {user.GamePoints}");
        }
    }
}
