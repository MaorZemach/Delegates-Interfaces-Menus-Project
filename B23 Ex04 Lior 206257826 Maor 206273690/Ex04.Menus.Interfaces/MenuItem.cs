using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private int m_CurrentMenuLevel;
        private string m_MenuName;

        internal MenuItem(string i_MenuName)
        {
            m_CurrentMenuLevel = 1;
            m_MenuName = i_MenuName;
        }

        internal int CurrentMenuLevel
        {
            get
            {
                return m_CurrentMenuLevel;
            }

            set
            {
                m_CurrentMenuLevel = value;
            }
        }

        internal string MenuName
        {
            get
            {
                return m_MenuName;
            }
        }

        internal abstract void ExecuteUserActionChoice();

        internal void PrintMenuName()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(string.Format("**{0}**", m_MenuName));
            Console.WriteLine("--------------------------------------------------");
        }

        internal void PrintMenuName(int i_IndexOfMenuItem)
        {
            Console.WriteLine(string.Format("{0} -> {1}", i_IndexOfMenuItem, m_MenuName));
        }
    }
}