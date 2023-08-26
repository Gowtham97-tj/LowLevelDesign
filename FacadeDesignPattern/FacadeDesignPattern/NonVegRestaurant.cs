using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
    public class NonVegRestaurant : IHotel
    {
        public IMenus getMenus()
        {
            NonVegMenu nv = new NonVegMenu();
            return nv;
        }
    }
}
