using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersion : IActionItem
    {
        public void ExecuteEvent()
        {
            Console.WriteLine("Version: 23.2.4.9805");
            Console.WriteLine();
        }
    }
}