using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
    public class HotelKeeperImplementation : IHotelKeeper
    {
        public VegMenu getVegMenu()
        {
            VegRestaurant v = new VegRestaurant();
            VegMenu vegMenu = (VegMenu)v.getMenus();
            return vegMenu;
        }

        public NonVegMenu getNonVegMenu()
        {
            NonVegRestaurant v = new NonVegRestaurant();
            NonVegMenu NonvegMenu = (NonVegMenu)v.getMenus();
            return NonvegMenu;
        }

        public Both getVegNonMenu()
        {
            VegNonBothRestaurant v = new VegNonBothRestaurant();
            Both bothMenu = (Both)v.getMenus();
            return bothMenu;
        }
    }
}
