using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder_4
{
    class BenzBuilder:CarBuilder
    {
        private BenzModel benz=new BenzModel();
        public override void SetSequence(List<string> sequence)
        {
            benz.SetSequence(sequence);
        }

        public override CarModel GetCarModel()
        {
            return this.benz;
        }
    }
}
