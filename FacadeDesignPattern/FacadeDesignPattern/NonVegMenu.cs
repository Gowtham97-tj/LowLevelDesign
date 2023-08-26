using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
    public class NonVegMenu : IMenus
    {
        public void execute()
        {
            Console.WriteLine("List of Non-Veg Menus");
        }
    }
}
