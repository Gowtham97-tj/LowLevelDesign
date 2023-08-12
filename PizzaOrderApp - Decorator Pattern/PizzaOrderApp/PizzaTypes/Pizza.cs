using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderApp
{
    public abstract class Pizza
    {
        public string description = "UnKnown Pizza";

        public virtual string getDescription()
        {
            return description;
        }

        public abstract int getCost(); 
    }
}
