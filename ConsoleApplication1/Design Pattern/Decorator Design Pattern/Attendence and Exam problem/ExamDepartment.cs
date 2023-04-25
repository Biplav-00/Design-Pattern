using System;

namespace ConsoleApplication1.Design_Pattern.Decorator_Design_Pattern.Attendence_and_Exam_problem
{
    public class ExamDepartment : IOrganization
    {
        public void examAttendence()
        {
            Console.WriteLine("Exam result is being published");
        }
    }
}