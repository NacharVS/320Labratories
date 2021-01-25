using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Tikhonov.GameCreationStart
{
    interface Ifields
    {




        string UserName { get; set; }
        //DateTime DayOfBirth { get; set; }
        int FinishedMatches { get; set; }
        int Victories { get; set; }
        int GamePoints { get; set; }

    }
}
