using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor_18
{
    class Visitor : IVisitor
    {
        public void Visit(Manager manager)
        {
            Console.WriteLine(GetManagerInfo(manager));            
        }

        public void Visit(CommonEmployee employee)
        {
            Console.WriteLine(GetCommonEmployeeInfo(employee));
        }

        string GetBasicInfo(Employee employee)
        {
            return $"姓名：{employee.Name}" +
                   $"\t性别：{employee.Sex}" +
                   $"\t工资：{employee.Salary}";
        }

        string GetManagerInfo(Manager manager)
        {
            string basicInfo = GetBasicInfo(manager);
            return basicInfo + $"\t业绩：{manager.Performance}";
        }

        string GetCommonEmployeeInfo(CommonEmployee employee)
        {
            string basicInfo = GetBasicInfo(employee);
            return basicInfo + $"\t工作：{employee.Job}";
        }
    }
}
