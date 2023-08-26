using System;

namespace FacadeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHotelKeeper keeper = new HotelKeeperImplementation();

            VegMenu v = keeper.getVegMenu();
            v.execute();
            NonVegMenu nv = keeper.getNonVegMenu();
            nv.execute();
            Both b = keeper.getVegNonMenu();
            b.execute();
        }
    }
}
