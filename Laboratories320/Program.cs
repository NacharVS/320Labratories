﻿using Laboratories320.Seydametov.Game;
using Laboratories320.Seydametov.Threading;
using System.Threading;
using System;
using Laboratories320.Seydametov.TPL;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread1.Thread_Main();
            //Thread_lock_prog.Thread_lock_Main();
            //Tpl.tpl();
            TplTask2.Start();
            
        }
    }
}
