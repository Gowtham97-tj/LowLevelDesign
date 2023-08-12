using PizzaOrderApp.Decorator;
using PizzaOrderApp.PizzaTypes;
using System;

namespace PizzaOrderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to Dominoz Pizza");

                foreach (PizzaType value in Enum.GetValues(typeof(PizzaType)))
                {
                    Console.WriteLine("Press " + ((int)value + 1) + " for " + value);
                }

                int input = Convert.ToInt16(Console.ReadLine());

                Pizza pizza = null;

                switch (input)
                {
                    case 1:
                        pizza = new SimplePizza();
                        break;
                    case 2:
                        pizza = new FarmHouse();
                        break;
                    case 3:
                        pizza = new Margherita();
                        break;
                    case 4:
                        pizza = new PeppyPaneer();
                        break;
                    default:
                        break;

                }

                Console.WriteLine("Want to add toppings?(y/n)");
                string toppings = Console.ReadLine();

                if (toppings == "y")
                {
                    Console.WriteLine("Please enter the toppings you want to add");
                    foreach (DecoratorType value in Enum.GetValues(typeof(DecoratorType)))
                    {
                        Console.WriteLine("Press " + ((int)value + 1) + " for " + value);
                    }

                    int type = Convert.ToInt16(Console.ReadLine());
                    switch (type)
                    {
                        case 1:
                            pizza = new Barbeque(pizza);
                            break;
                        case 2:
                            pizza = new FreshTomato(pizza);
                            break;
                        case 3:
                            pizza = new Paneer(pizza);
                            break;
                        default:
                            break;

                    }
                }
                Console.WriteLine("Your "+ pizza.getDescription() + " is ready");
                pizza.getDescription();
                Console.WriteLine("Total Bill: " + pizza.getCost());
                Console.WriteLine("Thank you for your valuable order");
            }
        }
    }
}
