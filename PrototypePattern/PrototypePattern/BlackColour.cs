using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class BlackColour : Colour
    {
        public BlackColour()
        {
            this.colorName = "Black";
        }

        public override void addColor()
        {
            Console.WriteLine("Black colour added");
        }
    }
}
