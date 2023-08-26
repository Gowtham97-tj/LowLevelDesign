using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Ken : Fighter
    {
        public Ken(IKickBehavior kickBehavior, IJumpBehavior jumpBehavior) : base(kickBehavior, jumpBehavior)
        {

        }

        public override void display()
        {
            Console.WriteLine("Ken");
        }
    }
}
