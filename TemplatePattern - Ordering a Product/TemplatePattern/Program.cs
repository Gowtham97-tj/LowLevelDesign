using System;

namespace TemplatePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            OrderProcessTemplate netOrder = new NetOrder();
            netOrder.processOrder(true);
            Console.WriteLine();
            OrderProcessTemplate storeOrder = new StoreOrder();
            storeOrder.processOrder(true);
        }
    }
}
