using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightPattern
{
    public class PlayerFactory
    {
        private static Dictionary<String, IPlayer> hm =
                         new Dictionary<String, IPlayer>();

        // Method to get a player
        public static IPlayer getPlayer(String type)
        {
            IPlayer p = null;

            /* If an object for TS or CT has already been
               created simply return its reference */
            if (hm.ContainsKey(type))
                p = hm.GetValueOrDefault(type);
            else
            {
                /* create an object of TS/CT  */
                switch (type)
                {
                    case "Terrorist":
                        Console.WriteLine("Terrorist Created");
                        p = new Terrorist();
                        break;
                    case "CounterTerrorist":
                        Console.WriteLine("Counter Terrorist Created");
                        p = new CounterTerrorist();
                        break;
                    default:
                        Console.WriteLine("Unreachable code!");
                        break;
                }

                // Once created insert it into the HashMap
                hm.Add(type, p);
            }
            return p;
        }
    }
}
