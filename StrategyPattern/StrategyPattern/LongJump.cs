using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class LongJump : IJumpBehavior
    {
        public void jump()
        {
            Console.WriteLine("Long Jump");
        }
    }
}
