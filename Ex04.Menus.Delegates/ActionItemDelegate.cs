using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class ActionItemDelegate : MenuItem
    {
        public event ActionInvoker EventHandler;

        internal ActionItemDelegate(string i_MenuName, ActionInvoker i_ActionInvoker) : base(i_MenuName)
        {
            this.EventHandler += i_ActionInvoker;
        }

        internal override void OnExecuteUserActionChoice()
        {
            if (EventHandler != null)
            {
                EventHandler.Invoke();
            }
        }
    }
}