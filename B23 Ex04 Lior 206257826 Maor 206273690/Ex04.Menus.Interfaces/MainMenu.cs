using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : SubMenuItem
    {
        internal MainMenu(string i_MenuName) : base(i_MenuName) { }

        public void Show()
        {
            Console.Clear();
            ExecuteUserActionChoice();
        }
    }
}