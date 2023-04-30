using System;
using System.Text;

namespace ConsoleApplication1.Design_Pattern.SOLID_Design.Single_Responsibility_Principle
{
    public class GenerateReport
    {
        public void generateEmployeeReport(Employee employee)
        {
            Console.WriteLine($"Report generation process begain of employee {employee.name}");
        }
    }
}