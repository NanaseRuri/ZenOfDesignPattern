using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DesignPattern.Prototype_6
{
    [Serializable]
    class Thing
    {
        private string _text = "hello";

        public void SetText(string text)
        {
            _text = text;
        }

        public void Print()
        {
            Console.WriteLine(_text);
        }

        public Thing Clone()
        {
            Thing thing = null;
            using (var ms=new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(ms, this);
                ms.Seek(0, SeekOrigin.Begin);
                thing= formatter.Deserialize(ms) as Thing;
                ms.Close();                
            }

            return thing;
        }
    }
}
