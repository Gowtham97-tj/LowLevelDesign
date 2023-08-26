using System;
using System.Collections.Generic;
using System.Text;

namespace CommandoPattern
{
    public class StereoOnWithCDCommand : ICommand
    {
        Stereo stereo;
        public StereoOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void execute()
        {
            stereo.on();
            stereo.setCD();
            stereo.setVolume(11);
        }
    }
}
