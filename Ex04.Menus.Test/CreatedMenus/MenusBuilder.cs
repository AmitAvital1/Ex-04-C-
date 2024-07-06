using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test.CreatedMenus
{
    public class MenusBuilder
    {
        public static Interfaces.MenuItem BuildInterfacesMenu()
        {
            
            Interfaces.MenuItem versionAndCapitalsItem = new Interfaces.MenuItem("Version and Capitals");
            Interfaces.MenuItem versionItem = new Interfaces.MenuItem("Show Version", new VersionHandler());
            Interfaces.MenuItem CapitalItem = new Interfaces.MenuItem("Count Capitals", new CapitalHandler());

            versionAndCapitalsItem.AddNewMenuItem(versionItem);
            versionAndCapitalsItem.AddNewMenuItem(CapitalItem);

            Interfaces.MenuItem dateAndTimeItem = new Interfaces.MenuItem("Show Date/Time");
            Interfaces.MenuItem dateItem = new Interfaces.MenuItem("Show Date", new DateProcedure());
            Interfaces.MenuItem timeItem = new Interfaces.MenuItem("Show Time", new TimeProcedure());

            dateAndTimeItem.AddNewMenuItem(timeItem);
            dateAndTimeItem.AddNewMenuItem(dateItem);

            Interfaces.MainMenu mainMenu = new Interfaces.MainMenu("Interfaces Main Menu");
            mainMenu.AddNewMenuItem(dateAndTimeItem);
            mainMenu.AddNewMenuItem(versionAndCapitalsItem);

            return mainMenu;
        }

        public static Events.Menu.MenuItem BuildEventsMenu()
        {
            Events.Menu.MenuItem versionAndCapitalsItem = new Events.Menu.MenuItem("Version and Capitals");
            Events.Menu.MenuItem versionItem = new Events.Menu.MenuItem("Show Version");
            versionItem.ItemAction += new VersionHandler().Execute;

            Events.Menu.MenuItem capitalItem = new Events.Menu.MenuItem("Count Capitals");
            capitalItem.ItemAction += new CapitalHandler().Execute;
           
            versionAndCapitalsItem.AddNewMenuItem(versionItem);
            versionAndCapitalsItem.AddNewMenuItem(capitalItem);

            Events.Menu.MenuItem dateAndTimeItem = new Events.Menu.MenuItem("Show Date/Time");
            Events.Menu.MenuItem dateItem = new Events.Menu.MenuItem("Show Date");
            dateItem.ItemAction += new DateProcedure().Execute;
            Events.Menu.MenuItem timeItem = new Events.Menu.MenuItem("Show Time");
            timeItem.ItemAction += new TimeProcedure().Execute;

            dateAndTimeItem.AddNewMenuItem(timeItem);
            dateAndTimeItem.AddNewMenuItem(dateItem);

            Events.Menu.MainMenu mainMenu = new Events.Menu.MainMenu("Delegates Main Menu");
            mainMenu.AddNewMenuItem(versionAndCapitalsItem);
            mainMenu.AddNewMenuItem(dateAndTimeItem);

            return mainMenu;
        }
    }
}
