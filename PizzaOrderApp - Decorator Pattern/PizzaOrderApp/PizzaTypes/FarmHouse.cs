using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderApp
{
    public class FarmHouse : Pizza
    {
        public FarmHouse()
        {
            description = "FarmHouse";
        }

        public override int getCost()
        {
            return 150;
        }
    }
}
