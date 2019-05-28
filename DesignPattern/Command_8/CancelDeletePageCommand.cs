using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Command_8
{
    class CancelDeletePageCommand:Command
    {
        public override void Execute()
        {
            pg.Rollback();            
        }
    }
}
