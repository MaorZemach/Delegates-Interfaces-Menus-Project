using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class ActionItem : MenuItem
    {
        private IActionItem m_Action;

        internal ActionItem(string i_MenuName, IActionItem i_IAction) : base(i_MenuName)
        {
            m_Action = i_IAction;
        }

        internal override void ExecuteUserActionChoice()
        {
            if (m_Action != null)
            {
                m_Action.ExecuteEvent();
            }
        }
    }
}