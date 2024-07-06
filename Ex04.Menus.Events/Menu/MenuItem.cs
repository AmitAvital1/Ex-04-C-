using System;
using System.Collections.Generic;

namespace Ex04.Menus.Events.Menu
{
    public class MenuItem
    {
        private string m_Title;
        private List<MenuItem> m_MenuItems;
        public Action ItemAction;
        protected eMenuExit m_ExitPrinter;

        public MenuItem(string i_Title, Action i_MenuItemAction)
        {
            m_Title = i_Title;
            m_ExitPrinter = eMenuExit.Back;
            m_MenuItems = new List<MenuItem>();
            ItemAction += i_MenuItemAction;
        }

        public MenuItem(string i_Title)
        {
            m_ExitPrinter = eMenuExit.Back;
            m_MenuItems = new List<MenuItem>();
            m_Title = i_Title;
        }

        protected virtual void OnMenuItemAction()
        {
            if (ItemAction != null)
            {
                ItemAction.Invoke();
            }
        }

        public string GetTitle()
        {
            return m_Title;
        }

        public void AddNewMenuItem(MenuItem i_MenuItem)
        {
            m_MenuItems.Add(i_MenuItem);
        }

        public List<MenuItem> GetMenuItems()
        {
            return m_MenuItems;
        }

        public void PrintMenu()
        {
            while (true)
            {
                printMenuFormat();

                try
                {
                    getUserMenuInput(out int o_UserInput, 0, m_MenuItems.Count);
                    Console.Clear();
                    if (o_UserInput == 0)
                    {
                        break;
                    }
                    else
                    {
                        menuItem_SelectedMenu(o_UserInput);
                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void menuItem_SelectedMenu(int i_UserInput)
        {
            MenuItem userSelectedItem = m_MenuItems[i_UserInput - 1];

            if (userSelectedItem.GetMenuItems().Count > 0)
            {
                userSelectedItem.PrintMenu();
            }
            else
            {
                userSelectedItem.OnMenuItemAction();
                Console.WriteLine("\n");
            }
        }

        private void printMenuFormat()
        {
            Console.WriteLine($"**{m_Title}**");
            Console.WriteLine("-----------------------");

            for (int i = 0; i < m_MenuItems.Count; i++)
            {
                Console.WriteLine($"{i + 1} -> {m_MenuItems[i].GetTitle()}");
            }

            Console.WriteLine($"0 -> {m_ExitPrinter}");
            Console.WriteLine($"Enter your request: (1-{m_MenuItems.Count} or press '0' to {m_ExitPrinter.ToString().ToLower()}).");
        }

        private void getUserMenuInput(out int o_UserInput, int i_MinValue, int i_MaxValue)
        {
            if (int.TryParse(Console.ReadLine(), out o_UserInput) == false)
            {
                throw new FormatException($"Invalid input. Please enter a number.");
            }
            else if (o_UserInput < i_MinValue || o_UserInput > i_MaxValue)
            {
                throw new InvalidRangeValueException(i_MinValue, i_MaxValue, "Choice");
            }
        }
    }
}
