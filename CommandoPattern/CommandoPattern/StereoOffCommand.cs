using System;
using System.Collections.Generic;
using System.Text;

namespace CommandoPattern
{
    public class StereoOffCommand : ICommand
    {
        Stereo stereo;
        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void execute()
        {
            stereo.off();
        }
    }
}
