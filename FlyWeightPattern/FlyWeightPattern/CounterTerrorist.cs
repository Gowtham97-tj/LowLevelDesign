using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightPattern
{
    public class CounterTerrorist : IPlayer
    {
        // Intrinsic Attribute
        private string task;
  
        // Extrinsic Attribute
        private string weapon;

        public CounterTerrorist()
        {
            task = "DIFFUSE BOMB";
        }
        public void assignWeapon(String weapon)
        {
            this.weapon = weapon;
        }
        public void mission()
        {
            Console.WriteLine("Counter Terrorist with weapon "
                               + weapon + "|" + " task is " + task);
        }
    }
}
