using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
    public class Both : IMenus
    {
        public void execute()
        {
            Console.WriteLine("List of Non-veg and Veg Menus");
        }
    }
}
