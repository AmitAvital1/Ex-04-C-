using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test.CreatedMenus
{
    public class DateProcedure : IMenuItemAction
    {
        public void Execute()
        {
            DateTime date = DateTime.Today;
            Console.WriteLine($"The Date is: {date.ToString("yyyy-MM-dd")}");
        }
    }
}
