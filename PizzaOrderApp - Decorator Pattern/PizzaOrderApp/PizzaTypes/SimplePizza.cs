using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderApp
{
    public class SimplePizza : Pizza
    {
        public SimplePizza()
        {
            description = "Simple";
        }

        public override int getCost()
        {
            return 80;
        }
    }
}
