using System;

namespace ConsoleApplication1.Design_Pattern.SOLID_Design.Single_Responsibility_Principle
{
    public class SalaryCalculator
    {
        public decimal calculateSalary(Employee employee)
        {
            Console.WriteLine($"Calculating the salary of employee {employee.name}");
            return employee.salary * 12;
        }
    }
}