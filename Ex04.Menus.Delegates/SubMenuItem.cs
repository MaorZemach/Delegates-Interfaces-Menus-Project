using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class SubMenuItem : MenuItem
    {
        protected readonly List<MenuItem> r_MenuItemsList;
        private SubMenuItem m_ParentMenuItem;

        internal SubMenuItem(string i_MenuName, SubMenuItem i_ParentMenu) : base(i_MenuName)
        {
            r_MenuItemsList = new List<MenuItem>();
            m_ParentMenuItem = i_ParentMenu;
            r_MenuItemsList.Add(MenuItemsBuilder.CreateActionItem("Back", null));
        }

        internal SubMenuItem(string i_MenuName) : base(i_MenuName)
        {
            r_MenuItemsList = new List<MenuItem>();
            m_ParentMenuItem = null;
            r_MenuItemsList.Add(MenuItemsBuilder.CreateActionItem("Exit", null));
        }

        public void AddItemToMenuList(MenuItem i_NewMenuItem)
        {
            i_NewMenuItem.CurrentMenuLevel = this.CurrentMenuLevel + 1;
            r_MenuItemsList.Add(i_NewMenuItem);
        }

        internal override void OnExecuteUserActionChoice()
        {
            int menuItemIdx;
            const int exitOrBackEvent = 0;
            int maxInputValueRange = r_MenuItemsList.Count - 1;
            int convertedUserInput = -1;

            while (convertedUserInput != exitOrBackEvent)
            {
                menuItemIdx = 0;
                PrintMenuName();

                foreach (MenuItem menuItem in r_MenuItemsList)
                {
                    menuItem.PrintMenuName(menuItemIdx);
                    ++menuItemIdx;
                }

                Console.WriteLine("--------------------------------------------------");
                convertedUserInput = ReadInputFromUser(0, maxInputValueRange);
                Console.Clear();
                r_MenuItemsList[convertedUserInput].OnExecuteUserActionChoice();
            }
        }

        private int ReadInputFromUser(int i_MinInputValueRange, int i_MaxInputValueRange)
        {
            bool v_isValidInput = false;
            string userInputString = string.Empty;
            int convertedUserInput = 0;

            while (!v_isValidInput)
            {
                Console.WriteLine($"Enter your request: ({i_MinInputValueRange + 1} to {i_MaxInputValueRange} or press '0' to {r_MenuItemsList[0].MenuName}).");
                userInputString = Console.ReadLine();

                try
                {
                    convertedUserInput = CheckInputValidity(userInputString, ref v_isValidInput);
                }

                catch (ValueOutOfRangeException exception)
                {
                    Console.WriteLine(exception.Message);
                }

                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format. The input value should be an integer in the range.");
                }
            }

            return convertedUserInput;
        }

        private int CheckInputValidity(string i_UserInputString, ref bool io_isValidInput)
        {
            int convertedUserInput = int.Parse(i_UserInputString);

            if (convertedUserInput > r_MenuItemsList.Count - 1 || convertedUserInput < 0)
            {
                throw new ValueOutOfRangeException(0, r_MenuItemsList.Count - 1);
            }

            else
            {
                io_isValidInput = true;

                return convertedUserInput;
            }
        }
    }
}