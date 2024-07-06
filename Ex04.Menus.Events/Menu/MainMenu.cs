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
