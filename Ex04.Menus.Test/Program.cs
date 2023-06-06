using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            InterfaceTest interfacesMenusTest = new InterfaceTest();
            DelegateTest delegatesMenusTest = new DelegateTest();

            interfacesMenusTest.Run();
            delegatesMenusTest.Run();
        }
    }
}