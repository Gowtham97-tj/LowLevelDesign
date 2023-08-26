using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class BirdAdapter : IToyDuck
    {
        IBird bird;
        public BirdAdapter(IBird bird)
        {
            // we need reference to the object we
            // are adapting
            this.bird = bird;
        }

        public void squeak()
        {
            // translate the methods appropriately
            bird.makeSound();
        }
    }
}
