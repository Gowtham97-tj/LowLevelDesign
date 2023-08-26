using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightPattern
{
    public interface IPlayer
    {
        public void assignWeapon(String weapon);
        public void mission();
    }
}
