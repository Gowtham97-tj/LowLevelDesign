using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderApp
{
    public class Paneer : ToppingsDecorator
    {
        Pizza pizza;

        public Paneer(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override string getDescription()
        {
            return pizza.description + " Paneer Pizza";
        }

        public override int getCost()
        {
            return 100 + pizza.getCost();
        }
    }
}
