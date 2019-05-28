using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator_10
{
    class HighScoreDecorator:Decorator
    {
        public HighScoreDecorator(ISchoolReport report) : base(report)
        {
        }

        public override void Report()
        {
            ReportHighScore();
            base.Report();
        }

        void ReportHighScore()
        {
            Console.WriteLine("高分");
        }
    }
}
