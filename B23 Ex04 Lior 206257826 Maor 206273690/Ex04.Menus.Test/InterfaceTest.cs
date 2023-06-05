using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceTest
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

            mainMenu = MenuItemsBuilder.CreateMainMenu("Interface Main Menu");
            subMenuItem1 = MenuItemsBuilder.CreateSubMenuItem("Show Date/Time", mainMenu);
            mainMenu.AddItemToMenuList(subMenuItem1);
            actionItem1_1 = MenuItemsBuilder.CreateActionItem("Show Date", new ShowDate());
            subMenuItem1.AddItemToMenuList(actionItem1_1);
            actionItem1_2 = MenuItemsBuilder.CreateActionItem("Show Time", new ShowTime());
            subMenuItem1.AddItemToMenuList(actionItem1_2);
            subMenuItem2 = MenuItemsBuilder.CreateSubMenuItem("Version and Spaces", mainMenu);
            mainMenu.AddItemToMenuList(subMenuItem2);
            actionItem2_1 = MenuItemsBuilder.CreateActionItem("Show Version", new ShowVersion());
            subMenuItem2.AddItemToMenuList(actionItem2_1);
            actionItem2_2 = MenuItemsBuilder.CreateActionItem("Count Spaces", new CountSpaces());
            subMenuItem2.AddItemToMenuList(actionItem2_2);

            return mainMenu;
        }
    }
}