using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Composition_13
{
    class Branch1:Branch
    {
        private List<Corp> _subordinateList = new List<Corp>();

        public Branch1(string name, string position, int salary) : base(name, position, salary)
        {
        }

        public void AddSubordinate(Corp corp)
        {
            _subordinateList.Add(corp);
        }

        public List<Corp> GetSubordinate()
        {
            return _subordinateList;
        }
    }
}
