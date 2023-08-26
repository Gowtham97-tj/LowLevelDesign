using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public abstract class Colour : ICloneable
    {
        protected String colorName;

        public abstract void addColor();

        public Object Clone()
        {
            Object clone = null;
            try
            {
                clone = base.MemberwiseClone();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return clone;
        }
    }
}
