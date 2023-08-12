using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderApp
{
    public class PeppyPaneer : Pizza
    {
        public PeppyPaneer()
        {
            description = "PeppyPaneer";
        }

        public override int getCost()
        {
            return 180;
        }
    }
}
