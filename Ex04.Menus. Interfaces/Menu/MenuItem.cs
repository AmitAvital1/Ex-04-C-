using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        protected string m_Title;
        protected List<MenuItem> m_SubMenuItems;    
        IMenuItemAction m_ItemAction;
        protected eMenuExit m_ExitPrinter;

        public MenuItem(string i_Title)
        {
            m_Title = i_Title;
            m_ExitPrinter = eMenuExit.Back;
            m_SubMenuItems = new List<MenuItem>();
        }

        public MenuItem(string i_Title, IMenuItemAction i_ItemAction) : this(i_Title)
        {
            m_ItemAction = i_ItemAction;
        }

        public string GetTitle()
        {
            return m_Title;
        }

        public List<MenuItem> GetMenuItems()
        {
            return m_SubMenuItems;
        }

        public IMenuItemAction GetItemAction()
        {
            return m_ItemAction;
        }

        public void PrintMenu()
        {
            while (true)
            {
                printMenuFormat();
                try
                {
                    getUserMenuInput(out int o_UserInput, 0, m_SubMenuItems.Count);
                    Console.Clear();
                    if (o_UserInput == 0)
                    {
                        break;
                    }
                    else
                    {
                        handleSelectedMenuItem(o_UserInput);
                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void printMenuFormat()
        {
            Console.WriteLine($"{m_Title}");
            Console.WriteLine("=======================");

            for (int i = 0; i < m_SubMenuItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {m_SubMenuItems[i].GetTitle()}");
            }

            Console.WriteLine($"0. {m_ExitPrinter}");
            Console.WriteLine($"Please enter your choice (1-{m_SubMenuItems.Count} or 0 to {m_ExitPrinter.ToString().ToLower()}");
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

        //TODO FIX IT!!!
        private void handleSelectedMenuItem(int i_UserInput)
        {
            MenuItem userSelectedItem = m_SubMenuItems[i_UserInput - 1];

            if (userSelectedItem.GetMenuItems().Count > 0)
            {
                userSelectedItem.printMenuFormat();
            }
            else
            {
                userSelectedItem.GetItemAction().Execute();
            }
        }
    }
}
