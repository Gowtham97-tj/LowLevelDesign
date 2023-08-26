using System;

namespace CommandoPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            Stereo stereo = new Stereo();

            // we can change command dynamically
            remote.setCommand(new LightOnCommand(light));
            remote.buttonWasPressed();
            remote.setCommand(new StereoOnWithCDCommand(stereo));
            remote.buttonWasPressed();
            remote.setCommand(new StereoOffCommand(stereo));
            remote.buttonWasPressed();
        }
    }
}
