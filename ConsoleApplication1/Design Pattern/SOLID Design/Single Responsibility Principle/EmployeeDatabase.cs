using System;

namespace ConsoleApplication1.Design_Pattern.SOLID_Design.Single_Responsibility_Principle
{
    public class EmployeeDatabase
    {
        public void saveEmployee(Employee employee)
        {
            Console.WriteLine($"Saving employee : {employee.name} in the database successfully");
        }
    }
}