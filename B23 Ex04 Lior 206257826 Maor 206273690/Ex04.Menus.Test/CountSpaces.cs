using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountSpaces : IActionItem
    {
        public void ExecuteAction()
        {
            int spacesCounter = 0;
            string userInputString;

            Console.WriteLine("Please enter your sentence:");
            userInputString = Console.ReadLine();

            foreach (char CharacterOfInputString in userInputString)
            {
                if (CharacterOfInputString.Equals(' '))
                {
                    ++spacesCounter;
                }
            }

            Console.WriteLine("There is/are {0} space/s in your sentence.", spacesCounter);
            Console.WriteLine();
        }
    }
}