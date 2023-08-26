using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public abstract class Fighter
    {
        IKickBehavior kickBehavior;
        IJumpBehavior jumpBehavior;
        public Fighter(IKickBehavior kickBehavior, IJumpBehavior jumpBehavior)
        {
            this.kickBehavior = kickBehavior;
            this.jumpBehavior = jumpBehavior;
        }

        public void punch()
        {
            Console.WriteLine("Default Punch");
        }

        public void kick()
        {
            // delegate to kick behavior
            kickBehavior.kick();
        }

        public void jump()
        {

            // delegate to jump behavior
            jumpBehavior.jump();
        }

        public void roll()
        {
            Console.WriteLine("Default Roll");
        }

        public void setKickBehavior(IKickBehavior kickBehavior)
        {
            this.kickBehavior = kickBehavior;
        }
        public void setJumpBehavior(IJumpBehavior jumpBehavior)
        {
            this.jumpBehavior = jumpBehavior;
        }
        public abstract void display();
    }
}
