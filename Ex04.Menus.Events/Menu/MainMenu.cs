﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events.Menu
{
    public class MainMenu : MenuItem
    {
        public MainMenu(string i_Title) : base(i_Title)
        {
            m_ExitPrinter = eMenuExit.Exit;
        }
    }
}
