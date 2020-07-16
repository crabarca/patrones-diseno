using System;
using System.Collections.Generic;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>();
            employees.Add(new Employee("Andres", 1_000_000));
            employees.Add(new Employee("Bruno", 1_200_000));
            employees.Add(new Employee("Carlos", 1_400_000));
            employees.Add(new Employee("Daniel", 800_000));
            employees.Add(new Employee("Esteban", 1_100_000));
            
            var payroll = new Payroll();
            foreach (var employee in employees)
            {
                payroll.TotalIncome += employee.Income;
                // employee.AddListener(payroll);
                employee.OnIncomeChanged += payroll.OnIncomeChanged;
            }
            
            Console.WriteLine($"Total income: {payroll.TotalIncome}");

            employees[0].Income += 200_000;
            
            Console.WriteLine($"Total income: {payroll.TotalIncome}");
        }
    }
}