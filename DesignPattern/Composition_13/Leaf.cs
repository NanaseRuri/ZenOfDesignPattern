using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Composition_13
{
    class Leaf:ILeaf
    {
        private string _name = "";
        private string _position = "";
        private int _salary = 0;

        public Leaf(string name, string position, int salary)
        {
            _name = name;
            _position = position;
            _salary = salary;
        }


        public string GetInfo()
        {
            string info = "";
            info += $"姓名： {_name}";
            info += $"\t职位： {_position}";
            info += $"\t薪水： {_salary}";
            return info;
        }
    }
}
