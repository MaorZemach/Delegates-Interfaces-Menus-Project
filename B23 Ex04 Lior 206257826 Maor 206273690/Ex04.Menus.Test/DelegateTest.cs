using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelegateTest
    {
        private MainMenu m_MainMenu;

        public void Run()
        {
            m_MainMenu = InitMenuItemsList();
            m_MainMenu.Show();
            Console.Clear();
        }

        public MainMenu InitMenuItemsList()
        {
            MainMenu mainMenu;
            SubMenuItem subMenuItem1;
            SubMenuItem subMenuItem2;
            ActionItem actionItem1_1;
            ActionItem actionItem1_2;
            ActionItem actionItem2_1;
            ActionItem actionItem2_2;

            mainMenu = MenuItemsBuilder.CreateMainMenu("Delegate Main Menu");
            subMenuItem1 = MenuItemsBuilder.CreateSubMenuItem("Show Date/Time", mainMenu);
            mainMenu.AddItemToMenuList(subMenuItem1);
            actionItem1_1 = MenuItemsBuilder.CreateActionItem("Show Date", ShowDate);
            subMenuItem1.AddItemToMenuList(actionItem1_1);
            actionItem1_2 = MenuItemsBuilder.CreateActionItem("Show Time", ShowTime);
            subMenuItem1.AddItemToMenuList(actionItem1_2);
            subMenuItem2 = MenuItemsBuilder.CreateSubMenuItem("Version and Spaces", mainMenu);
            mainMenu.AddItemToMenuList(subMenuItem2);
            actionItem2_1 = MenuItemsBuilder.CreateActionItem("Show Version", ShowVersion);
            subMenuItem2.AddItemToMenuList(actionItem2_1);
            actionItem2_2 = MenuItemsBuilder.CreateActionItem("Count Spaces", CountSpaces);
            subMenuItem2.AddItemToMenuList(actionItem2_2);

            return mainMenu;
        }

        public void ShowDate()
        {
            Console.WriteLine("The date is: {0}", DateTime.Now.ToString("dd/MM/yyyy"));
            Console.WriteLine();
        }

        public void ShowTime()
        {
            Console.WriteLine("The time is: {0}", DateTime.Now.ToString("h:mm:ss"));
            Console.WriteLine();
        }

        public void ShowVersion()
        {
            Console.WriteLine("Version: 23.2.4.9805");
            Console.WriteLine();
        }

        public void CountSpaces()
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