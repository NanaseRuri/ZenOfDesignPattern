using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Command_8
{
    class RequirementGroup:Group
    {
        public override void Find()
        {
            Console.WriteLine("找到需求组");
        }

        public override void Add()
        {
            Console.WriteLine("增加需求");
        }

        public override void Delete()
        {
            Console.WriteLine("删除请求");
        }

        public override void Change()
        {
            Console.WriteLine("变更请求");
        }

        public override void Plan()
        {
            Console.WriteLine("计划");
        }

        public override void Rollback()
        {
            throw new NotImplementedException();
        }
    }
}
