using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyDesignPattern
{
    public class RealInternet : IInternet
    {
        public void connectTo(String serverhost)
        {
            Console.WriteLine("Connecting to " + serverhost);
        }
    }
}
