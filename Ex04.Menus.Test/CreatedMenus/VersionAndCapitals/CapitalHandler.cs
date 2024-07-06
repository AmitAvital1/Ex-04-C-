using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test.CreatedMenus
{
    internal class CapitalHandler : IMenuItemAction
    {
        public void Execute()
        {
            string userSentence;
            int countNumberOfUpperCases;

            Console.WriteLine("Please Enter Your Sentence:");
            userSentence = Console.ReadLine();
            countNumberOfUpperCases = userSentence.Count(char.IsUpper);
            Console.WriteLine($"There Are {countNumberOfUpperCases} upper case letters in your sentence.");
        }
    }
}
