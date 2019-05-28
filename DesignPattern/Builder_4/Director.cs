using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder_4
{
    class Director
    {
        private List<string> sequence = new List<string>();
        BenzBuilder benzBuilder=new BenzBuilder();

        public BenzModel GetBenzModel()
        {
            sequence.Clear();
            sequence.Add("start");
            sequence.Add("stop");
            benzBuilder.SetSequence(sequence);
            return (BenzModel)benzBuilder.GetCarModel();
        }
        
    }
}
