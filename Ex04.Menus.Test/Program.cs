using Ex04.Menus.Test.CreatedMenus;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            runMenuTests();
        }

        private static void runMenuTests()
        {
            Interfaces.MenuItem m_MainMenuInterface = MenusBuilder.BuildInterfacesMenu();
            m_MainMenuInterface.PrintMenu();

            Events.Menu.MenuItem m_MainMenuEvent = MenusBuilder.BuildEventsMenu();
            m_MainMenuEvent.PrintMenu();
        }
    }
}
