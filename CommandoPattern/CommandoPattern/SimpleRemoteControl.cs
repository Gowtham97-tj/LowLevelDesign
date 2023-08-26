using System;
using System.Collections.Generic;
using System.Text;

namespace CommandoPattern
{
    public class SimpleRemoteControl
    {
        ICommand slot;  // only one button

        public SimpleRemoteControl()
        {
        }

        public void setCommand(ICommand command)
        {
            // set the command the remote will
            // execute
            slot = command;
        }

        public void buttonWasPressed()
        {
            slot.execute();
        }
    }
}
