using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Command_8
{
    class Invoker
    {
        private Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        public void Action()
        {
            _command.Execute();
        }
    }
}
