using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Command_8
{
    class AddRequirementCommand:Command
    {
        private Receiver _receiver;

        public AddRequirementCommand(Receiver receiver)
        {
            _receiver = receiver;
        }

        public override void Execute()
        {
            rg.Find();
            rg.Add();
            rg.Plan();
            _receiver.DoSomething();            
        }
    }
}
