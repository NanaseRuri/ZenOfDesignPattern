using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Command_8
{
    abstract class Group
    {
        public abstract void Find();
        public abstract void Add();
        public abstract void Delete();
        public abstract void Change();
        public abstract void Plan();
        public abstract void Rollback();
    }
}
