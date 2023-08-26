using System;

namespace ProxyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IInternet internet = new ProxyInternet();
            try
            {
                internet.connectTo("geeksforgeeks.org");
                internet.connectTo("abc.com");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
