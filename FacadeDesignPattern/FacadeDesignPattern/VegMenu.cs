using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
    public class VegMenu : IMenus
    {
        public void execute()
        {
            Console.WriteLine("List of Veg Menus");
        }
    }
}
