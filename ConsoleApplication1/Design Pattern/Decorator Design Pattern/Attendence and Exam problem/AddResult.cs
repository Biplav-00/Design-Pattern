using System;

namespace ConsoleApplication1.Design_Pattern.Decorator_Design_Pattern.Attendence_and_Exam_problem
{
    public abstract class AddResult : IOrganization
    {
        private IOrganization _organization;
        public virtual void publishResult(IOrganization organization)
        {
            this._organization = organization;
        }

        public void examAttendence()
        {
            _organization.examAttendence();
            
        }

        public void addResult()
        {
            Console.WriteLine("Exam result is being published");
        }
    }
}