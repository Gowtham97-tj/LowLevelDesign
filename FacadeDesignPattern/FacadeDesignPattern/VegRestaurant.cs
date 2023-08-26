using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
    public class VegRestaurant
    {
        public IMenus getMenus()
        {
            VegMenu v = new VegMenu();
            return v;
        }
    }
}
