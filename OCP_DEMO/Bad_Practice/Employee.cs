namespace NoOCP
{
    public class Employee 
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public decimal BasicSalary { get; set; }

        // Added later, after class created
        public string Type { get; set; }

        public decimal CalcHoursBonus(decimal hours)
        {
            // Added later, after class created
            if (Type == "manager") return ((((BasicSalary / 30) / 8) * hours) * 2);
            
            return (((BasicSalary / 30) / 8) * hours);
        }

        public override string ToString() 
        {
            return $"Employee ID: {ID}, Name: {Name}";
        }
    }
}