using System;
using System.Collections.Generic;
using System.Linq;

namespace OCP
{
    class BestPractice
    {
        public void Run()
        {
            RegularEmp employee1 = new RegularEmp();

            employee1.ID = "1234";
            employee1.Name = "Faisal Alkhotaifi";
            employee1.BasicSalary = 900;

            Console.WriteLine(
                employee1.ToString()
                + Environment.NewLine
                + "Bonus: " + employee1.CalcHoursBonus(5).ToString()
            );

            ManagerEmp employee2 = new ManagerEmp();

            employee2.ID = "5678";
            employee2.Name = "Faisal Alkhotaifi 2";
            employee2.BasicSalary = 900;

            Console.WriteLine(
                employee2.ToString()
                + Environment.NewLine
                + "Bonus: " + employee2.CalcHoursBonus(5).ToString()
            );

            SenoirEmp employee3 = new SenoirEmp();

            employee3.ID = "5678";
            employee3.Name = "Faisal Alkhotaifi 2";
            employee3.BasicSalary = 900;

            Console.WriteLine(
                employee3.ToString()
                + Environment.NewLine
                + "Bonus: " + employee3.CalcHoursBonus(5).ToString()
            );
        }
    }
}