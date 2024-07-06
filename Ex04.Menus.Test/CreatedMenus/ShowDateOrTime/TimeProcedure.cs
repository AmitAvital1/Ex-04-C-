using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test.CreatedMenus
{
    public class TimeProcedure : IMenuItemAction
    {
        public void Execute()
        {
            DateTime time = DateTime.Now;

            Console.WriteLine($"The Hour is: {time.ToString("HH:mm:ss")}");
        }
    }
}
