using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class LightningKick : IKickBehavior
    {
        public void kick()
        {
            Console.WriteLine("Lightning Kick");
        }
    }
}
