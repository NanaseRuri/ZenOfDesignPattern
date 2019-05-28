using System;
using System.Collections;
using System.Collections.Generic;
using DesignPattern.Builder_4;
using DesignPattern.Decorator_10;
using DesignPattern.Flyweight_21;
using DesignPattern.Prototype_6;
using DesignPattern.State_19;
using DesignPattern.Strategy_11;
using DesignPattern.Visitor_18;
using Environment = DesignPattern.State_19.Environment;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            

            ////4
            //Director director=new Director();
            //for (int i = 0; i < 10; i++)
            //{
            //    director.GetBenzModel().Run();
            //}


            //6
            //Thing thing=new Thing();            

            //for (int i = 0; i < 6; i++)
            //{
            //    Thing cloneThing = thing.Clone();
            //}

            ////10
            //ISchoolReport sr = null;
            //sr=new ChildrenSchoolReport();
            //sr=new RangeDecorator(sr);
            //sr=new HighScoreDecorator(sr);
            //sr.Report();
            //sr.Sign("爸爸");

            //11
            //HelloStrategy hs=new HelloStrategy();
            //GoodbyeStrategy gs=new GoodbyeStrategy();
            //Context man=new Context(hs);
            //man.Operate();
            //man=new Context(gs);
            //man.Operate();


            //18
            //foreach (var employee in MockEmployee())
            //{
            //    employee.Accept(new Visitor());
            //}

            //19
            //Environment environment = new Environment(new ClosingState());
            //environment.Open();
            //environment.Close();
            //environment.Run();
            //environment.Stop();                        

            //21
            for (int i = 0; i < 2; i++)
            {
                string subject = $"科目{i}";
                for (int j = 0; j < 20; j++)
                {
                    string key = subject + $"地点：{j}";
                    SignInfoFactory.GetSignInfo(key);
                }
            }
        }

        static List<Employee> MockEmployee()
        {
            List<Employee> employees = new List<Employee>();
            CommonEmployee e1=new CommonEmployee()
            {
                Name = "e1",
                Job = "打工仔",
                Sex = Sex.Man,
                Salary = 5000
            };            
            CommonEmployee e2=new CommonEmployee()
            {
                Name = "e2",
                Job = "打工仔2号",
                Sex = Sex.Female,
                Salary = 6000
            };
            Manager manager=new Manager()
            {
                Sex = Sex.Female,
                Performance = "呵呵",
                Name = "Ma",
                Salary = 6000
            };
            employees.Add(e1);
            employees.Add(e2);
            employees.Add(manager);
            return employees;
        }
    }
}
