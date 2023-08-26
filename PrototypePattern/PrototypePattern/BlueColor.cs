using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class BlueColor : Colour
    {
        public BlueColor()
        {
            this.colorName = "blue";
        }

        public override void addColor()
        {
            Console.WriteLine("Blue colour added");
        }
    }
}
