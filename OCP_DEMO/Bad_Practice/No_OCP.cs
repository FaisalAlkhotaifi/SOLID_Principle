using System;
using System.Collections.Generic;
using System.Linq;

namespace NoOCP
{
    class BadPractice
    {
        public void Run()
        {
            Employee employee1 = new Employee();

            employee1.ID = "1234";
            employee1.Name = "Faisal Alkhotaifi";
            employee1.BasicSalary = 900;

            // Added Later
            employee1.Type = "regular";

            Console.WriteLine(
                employee1.ToString()
                + Environment.NewLine
                + "Bonus: " + employee1.CalcHoursBonus(5).ToString()
            );

            Employee employee2 = new Employee();

            employee2.ID = "5678";
            employee2.Name = "Faisal Alkhotaifi 2";
            employee2.BasicSalary = 900;

            // Added Later
            employee2.Type = "manager";

            Console.WriteLine(
                employee2.ToString()
                + Environment.NewLine
                + "Bonus: " + employee2.CalcHoursBonus(5).ToString()
            );
        }
    }
}