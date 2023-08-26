using System;
using System.Collections.Generic;
using System.Text;

namespace CommandoPattern
{
    public class Stereo
    {
        public void on()
        {
            Console.WriteLine("Stereo is on");
        }
        public void off()
        {
            Console.WriteLine("Stereo is off");
        }
        public void setCD()
        {
            Console.WriteLine("Stereo is set " +
                               "for CD input");
        }
        public void setDVD()
        {
            Console.WriteLine("Stereo is set" +
                             " for DVD input");
        }
        public void setRadio()
        {
            Console.WriteLine("Stereo is set" +
                               " for Radio");
        }
        public void setVolume(int volume)
        {
            // code to set the volume
            Console.WriteLine("Stereo volume set"
                               + " to " + volume);
        }
    }
}
