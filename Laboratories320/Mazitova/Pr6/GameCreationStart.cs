using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Mazitova.Pr6
{
    class GameCreationStart
    {
        private string UserName { get; set; }
        private DateTime DayOfBirth { get; set; }
        private int FinishedMatches { get; set; }
        private int Victories { get; set; }
        private int GamePoints { get; set; }

        List<GameCreationStart> gameUser = new List<GameCreationStart> 
        {
        
        };

        public void SearchByName( string name)
        {
            Parallel.ForEach(gameUser, user =>
           {
               if (user.UserName == name)
               {
                   Console.WriteLine("Имя пользователя: {0}");
               }
           });
        }

       
    }
}
