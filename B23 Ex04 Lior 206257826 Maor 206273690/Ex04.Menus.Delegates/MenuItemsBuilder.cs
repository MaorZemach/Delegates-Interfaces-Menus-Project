using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public static class MenuItemsBuilder
    {
        public static MainMenu CreateMainMenu(string i_MainMenuName)
        {
            MainMenu newMainMenu;
            newMainMenu = new MainMenu(i_MainMenuName);

            return newMainMenu;
        }

        public static SubMenuItem CreateSubMenuItem(string i_SubMenuName, SubMenuItem i_ParentMenuItem)
        {
            SubMenuItem newSubMenuItem;
            newSubMenuItem = new SubMenuItem(i_SubMenuName, i_ParentMenuItem);

            return newSubMenuItem;
        }

        public static ActionItem CreateActionItem(string i_ActionName, ActionInvoker i_ActionInvoker)
        {
            ActionItem newActionItem;
            newActionItem = new ActionItem(i_ActionName, i_ActionInvoker);

            return newActionItem;
        }
    }
}