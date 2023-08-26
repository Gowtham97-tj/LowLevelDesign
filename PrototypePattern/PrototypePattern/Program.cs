using System;

namespace PrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColourStore.getColor("blue").addColor();
            ColourStore.getColor("black").addColor();
            ColourStore.getColor("black").addColor();
            ColourStore.getColor("blue").addColor();
        }
    }
}
