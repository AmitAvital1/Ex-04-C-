using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test.CreatedMenus
{
    public class VersionHandler : IMenuItemAction
    {
        public void Execute()
        {
            Console.WriteLine("App Version: 24.2.4.9504");
        }
    }
}
