using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Command_8
{
    class DeletePageCommand:Command
    {
        public override void Execute()
        {
            pg.Find();
            pg.Delete();
            pg.Plan();
        }
    }
}
