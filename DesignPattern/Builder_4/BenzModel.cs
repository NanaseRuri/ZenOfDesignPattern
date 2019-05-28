using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder_4
{
    class BenzModel:CarModel
    {
        List<string> _sequence=new List<string>();

        protected override void Start()
        {
            Console.WriteLine("启动奔驰");
        }

        protected override void Stop()
        {
            Console.WriteLine("停");
        }

        protected override void Alarm()
        {
            Console.WriteLine("嘟嘟嘟");
        }

        protected override void EngineBoom()
        {
            Console.WriteLine("引擎轰鸣");
        }

        public void SetSequence(List<string> sequence)
        {
            _sequence = sequence;
        }
    }
}
