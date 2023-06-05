using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDate : IActionItem
    {
        public void ExecuteAction()
        {
            Console.WriteLine("The date is: {0}", DateTime.Now.ToString("dd/MM/yyyy"));
            Console.WriteLine();
        }
    }
}