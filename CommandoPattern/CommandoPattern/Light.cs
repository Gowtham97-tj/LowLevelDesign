using System;
using System.Collections.Generic;
using System.Text;

namespace CommandoPattern
{
    public class Light
    {
        public void on()
        {
            Console.WriteLine("Light is on");
        }
        public void off()
        {
            Console.WriteLine("Light is off");
        }
    }
}
