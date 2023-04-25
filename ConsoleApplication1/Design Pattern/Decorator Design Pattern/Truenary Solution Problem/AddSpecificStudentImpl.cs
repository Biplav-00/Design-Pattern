using System;

namespace ConsoleApplication1.Design_Pattern.Decorator_Design_Pattern.Truenary_Solution_Problem
{
    public class AddSpecificStudentImpl : AddSpecificStudent
    {
        public AddSpecificStudentImpl(ITruenarySolution truenarySolution) : base(truenarySolution)
        {
        }

        public override void webDevelopmentIntern()
        {
            base.webDevelopmentIntern();
            Console.WriteLine("Hello I am new student please welcome me");
        }
    }
}