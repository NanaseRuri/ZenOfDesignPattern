using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Command_8
{
    abstract class Command
    {
        protected RequirementGroup rg=new RequirementGroup();
        protected PageGroup pg=new PageGroup();
        protected CodeGroup cg=new CodeGroup();

        public abstract void Execute();
    }
}
