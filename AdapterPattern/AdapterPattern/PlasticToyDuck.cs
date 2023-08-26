using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class PlasticToyDuck : IToyDuck
    {
        public void squeak()
        {
            Console.WriteLine("Squeak");
        }
    }
}
