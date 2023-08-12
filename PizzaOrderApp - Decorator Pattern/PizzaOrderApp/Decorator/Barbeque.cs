using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderApp.Decorator
{
    public class Barbeque : ToppingsDecorator
    {
        Pizza pizza;

        public Barbeque(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override string getDescription()
        {
            return pizza.description + " Barbeque Pizza";
        }

        public override int getCost()
        {
            return 200 + pizza.getCost();
        }
    }
}
