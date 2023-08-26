using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class ColourStore
    {
        private static Dictionary<String, Colour> colorMap = new Dictionary<String, Colour>();

        static ColourStore()
        {
            colorMap.Add("blue", new BlueColor());
            colorMap.Add("black", new BlackColour());
        }
            
    public static Colour getColor(String colorName)
    {
        return (Colour)colorMap.GetValueOrDefault(colorName).Clone();
    }
}
}
