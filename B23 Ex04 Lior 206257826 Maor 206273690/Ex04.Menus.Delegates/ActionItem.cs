using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class ActionItem : MenuItem
    {
        private event ActionInvoker ActionInvoker;

        internal ActionItem(string i_MenuName, ActionInvoker i_ActionInvoker) : base(i_MenuName)
        {
            this.ActionInvoker += i_ActionInvoker;
        }

        internal override void OnExecuteUserActionChoice()
        {
            if (ActionInvoker != null)
            {
                ActionInvoker.Invoke();
            }
        }
    }
}