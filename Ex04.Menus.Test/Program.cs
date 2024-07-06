using Ex04.Menus.Interfaces;
using Ex04.Menus.Events;
using Ex04.Menus.Test.CreatedMenus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            Interfaces.MenuItem m_MainMenuInterface = MenusBuilder.BuildInterfacesMenu();
            m_MainMenuInterface.PrintMenu();

            Events.Menu.MenuItem m_MainMenuEvent = MenusBuilder.BuildEventsMenu();
            m_MainMenuEvent.PrintMenu();
        }
    }
}
