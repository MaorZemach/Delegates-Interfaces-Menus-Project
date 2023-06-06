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
        private Interfaces.MainMenu m_MainMenu;

        public void Run()
        {
            m_MainMenu = InitMenuItemsList();
            m_MainMenu.Show();
            Console.Clear();
        }

        public MainMenu InitMenuItemsList()
        {
            MainMenu mainMenu;
            SubMenuItem interfaceSubMenuItem1;
            SubMenuItem interfaceSubMenuItem2;
            ActionItem interfaceActionItem1_1;
            ActionItem interfaceActionItem1_2;
            ActionItem interfaceActionItem2_1;
            ActionItem interfaceActionItem2_2;

            mainMenu = MenuItemsBuilder.CreateMainMenu("Interface Main Menu");
            interfaceSubMenuItem1 = MenuItemsBuilder.CreateSubMenuItem("Show Date/Time", mainMenu);
            mainMenu.AddItemToMenuList(interfaceSubMenuItem1);
            interfaceActionItem1_1 = MenuItemsBuilder.CreateActionItem("Show Date", new ShowDate());
            interfaceSubMenuItem1.AddItemToMenuList(interfaceActionItem1_1);
            interfaceActionItem1_2 = MenuItemsBuilder.CreateActionItem("Show Time", new ShowTime());
            interfaceSubMenuItem1.AddItemToMenuList(interfaceActionItem1_2);
            interfaceSubMenuItem2 = MenuItemsBuilder.CreateSubMenuItem("Version and Spaces", mainMenu);
            mainMenu.AddItemToMenuList(interfaceSubMenuItem2);
            interfaceActionItem2_1 = MenuItemsBuilder.CreateActionItem("Show Version", new ShowVersion());
            interfaceSubMenuItem2.AddItemToMenuList(interfaceActionItem2_1);
            interfaceActionItem2_2 = MenuItemsBuilder.CreateActionItem("Count Spaces", new CountSpaces());
            interfaceSubMenuItem2.AddItemToMenuList(interfaceActionItem2_2);

            return mainMenu;
        }
    }
}