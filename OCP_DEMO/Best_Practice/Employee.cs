namespace OCP
{
    public abstract class Employee 
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public decimal BasicSalary { get; set; }

        // Each type of employee should do its own implementation.
        public abstract decimal CalcHoursBonus(decimal hours);

        public override string ToString() 
        {
            return $"Employee ID: {ID}, Name: {Name}";
        }
    }

    public class ManagerEmp : Employee
    {
        public override decimal CalcHoursBonus(decimal hours)
        {
            return ((((BasicSalary / 30) / 8) * hours) * 3);
        }
    }


    public class RegularEmp : Employee
    {
        public override decimal CalcHoursBonus(decimal hours)
        {
            return (((BasicSalary / 30) / 8) * hours);
        }
    }

    public class SenoirEmp : Employee
    {
        public override decimal CalcHoursBonus(decimal hours)
        {
            return (((BasicSalary / 30) / 8) * hours) * 2;
        }
    }
}