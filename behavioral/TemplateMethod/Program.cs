using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new RegularEmployee(25, RegularEmployee.ContractType.FullTime);
            employee.ExtraHoursWorked = 10;
            employee.Commissions = 1000;
            
            var intern = new Intern();
            
            Console.WriteLine($"Regular employee salary is {employee.CalculateSalary()}");
            Console.WriteLine($"Intern salary is {intern.CalculateSalary()}");
        }
    }
}