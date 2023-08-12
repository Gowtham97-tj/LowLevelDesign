using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderApp
{
    public class Margherita : Pizza
    {
        public Margherita()
        {
            description = "Margherita";
        }

        public override int getCost()
        {
            return 110;
        }
    }
}
