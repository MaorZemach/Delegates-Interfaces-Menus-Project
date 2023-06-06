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
        private Delegates.MainMenu m_MainMenu;

        public void Run()
        {
            m_MainMenu = InitMenuItemsList();
            m_MainMenu.Show();
            Console.Clear();
        }

        public MainMenu InitMenuItemsList()
        {
            MainMenu delegatesMainMenu;
            SubMenuItem delegateSubMenuItem1;
            SubMenuItem delegateSubMenuItem2;
            ActionItemDelegate delegateActionItem1_1;
            ActionItemDelegate delegateActionItem1_2;
            ActionItemDelegate delegateActionItem2_1;
            ActionItemDelegate delegateActionItem2_2;

            delegatesMainMenu = MenuItemsBuilder.CreateMainMenu("Delegate Main Menu");
            delegateSubMenuItem1 = MenuItemsBuilder.CreateSubMenuItem("Show Date/Time", delegatesMainMenu);
            delegatesMainMenu.AddItemToMenuList(delegateSubMenuItem1);
            delegateActionItem1_1 = MenuItemsBuilder.CreateActionItem("Show Date", ShowDate);
            delegateSubMenuItem1.AddItemToMenuList(delegateActionItem1_1);
            delegateActionItem1_2 = MenuItemsBuilder.CreateActionItem("Show Time", ShowTime);
            delegateSubMenuItem1.AddItemToMenuList(delegateActionItem1_2);
            delegateSubMenuItem2 = MenuItemsBuilder.CreateSubMenuItem("Version and Spaces", delegatesMainMenu);
            delegatesMainMenu.AddItemToMenuList(delegateSubMenuItem2);
            delegateActionItem2_1 = MenuItemsBuilder.CreateActionItem("Show Version", ShowVersion);
            delegateSubMenuItem2.AddItemToMenuList(delegateActionItem2_1);
            delegateActionItem2_2 = MenuItemsBuilder.CreateActionItem("Count Spaces", CountSpaces);
            delegateSubMenuItem2.AddItemToMenuList(delegateActionItem2_2);

            return delegatesMainMenu;
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