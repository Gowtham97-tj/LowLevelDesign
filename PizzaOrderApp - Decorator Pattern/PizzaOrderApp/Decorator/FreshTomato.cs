using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderApp
{
    public class FreshTomato : ToppingsDecorator
    {
        Pizza pizza;

        public FreshTomato(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override string getDescription()
        {
            return pizza.description + " FreshTomato Pizza";
        }

        public override int getCost()
        {
            return 50 + pizza.getCost();
        }
    }
}
