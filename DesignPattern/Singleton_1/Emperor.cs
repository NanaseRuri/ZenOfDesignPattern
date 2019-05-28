using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace DesignPattern.Singleton_1
{
    class Emperor
    {
        private Emperor() { }

        private Emperor(string name)
        {
            _names.Add(name);
        }

        static Emperor()
        {
            for (int i = 0; i < MaxValue; i++)
            {
                _emperors.Add(new Emperor($"周{i}艺"));
            }
        }

        private static List<Emperor> _emperors=new List<Emperor>();
        private static List<string> _names=new List<string>();
        private const int MaxValue = 2; 

        public static void Say()
        {
            int id=new Random().Next(MaxValue);
            Console.WriteLine(_names[id]);
        }

        public static Emperor GetEmperor()
        {
            int id=new Random().Next(MaxValue);
            return _emperors[id];            
        }
    }
}
