using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
    public class VegNonBothRestaurant : IHotel
    {
        public IMenus getMenus()
        {
            Both b = new Both();
            return b;
        }
    }
}
