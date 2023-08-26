using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
    public interface IHotelKeeper
    {
        public VegMenu getVegMenu();
        public NonVegMenu getNonVegMenu();
        public Both getVegNonMenu();
    }
}
