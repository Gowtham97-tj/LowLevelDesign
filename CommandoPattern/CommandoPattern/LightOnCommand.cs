using System;
using System.Collections.Generic;
using System.Text;

namespace CommandoPattern
{
    public class LightOnCommand : ICommand
    {
        Light light;
        public LightOnCommand(Light light)
        {
            this.light = light;
        }
        public void execute()
        {
            light.on();
        }
    }
}
