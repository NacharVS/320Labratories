using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Dyubanov.GameCreationStart
{
    class Start
    {

        public void start()
        {
            User us = new User("Vitala", 10, 5, 1000, DateTime.Today);
            Console.WriteLine(us.DayOfBirth);
        }
    }
}
