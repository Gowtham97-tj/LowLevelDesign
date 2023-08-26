using System;

namespace StrategyPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            IJumpBehavior shortJump = new ShortJump();
            IJumpBehavior LongJump = new LongJump();
            IKickBehavior tornadoKick = new TornadoKick();

            // Make a fighter with desired behaviors
            Fighter ken = new Ken(tornadoKick, shortJump);
            ken.display();

            // Test behaviors
            ken.punch();
            ken.kick();
            ken.jump();

            // Change behavior dynamically (algorithms are
            // interchangeable)
            ken.setJumpBehavior(LongJump);
            ken.jump();
        }
    }
}
