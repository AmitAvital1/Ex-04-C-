using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
