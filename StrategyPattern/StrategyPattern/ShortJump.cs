using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class ShortJump : IJumpBehavior
    {
        public void jump()
        {
            Console.WriteLine("Short Jump");
        }
    }
}
