using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightPattern
{
    public class Terrorist : IPlayer
    {
        private String task;
  
    // Extrinsic Attribute
    private String weapon;

        public Terrorist()
        {
            task = "PLANT A BOMB";
        }
        public void assignWeapon(String weapon)
        {
            // Assign a weapon
            this.weapon = weapon;
        }
        public void mission()
        {
            Console.WriteLine("Terrorist with weapon "
                               + weapon + "|" + " task is " + task);
        }
    }
}
