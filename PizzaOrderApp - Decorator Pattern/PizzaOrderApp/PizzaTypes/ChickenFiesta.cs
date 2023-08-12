using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderApp
{
    public class ChickenFiesta : Pizza
    {
        public ChickenFiesta()
        {
            description = "Chicken Fiesta";
        }

        public override int getCost()
        {
            return 200;
        }
    }
}
