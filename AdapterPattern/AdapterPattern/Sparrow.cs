using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Sparrow : IBird
    {
        public void fly()
        {
            Console.WriteLine("Flying");
        }
        public void makeSound()
        {
            Console.WriteLine("Chirp Chirp");
        }
    }
}
