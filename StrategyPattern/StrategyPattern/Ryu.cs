using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Ryu : Fighter
    {
        public Ryu(IKickBehavior kickBehavior, IJumpBehavior jumpBehavior) : base(kickBehavior, jumpBehavior)
        {
            
        }
        public override void display()
        {
            Console.WriteLine("Ryu");
        }
    }
}
