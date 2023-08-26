using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class TornadoKick : IKickBehavior
    {
        public void kick()
        {
            Console.WriteLine("Tornado Kick");
        }
    }
}
