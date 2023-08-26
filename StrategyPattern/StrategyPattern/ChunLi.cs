using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class ChunLi : Fighter
    {
        public ChunLi(IKickBehavior kickBehavior, IJumpBehavior jumpBehavior) : base(kickBehavior, jumpBehavior)
        {

        }
        public override void display()
        {
            Console.WriteLine("ChunLi");
        }
    }
}
