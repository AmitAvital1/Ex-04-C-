using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
