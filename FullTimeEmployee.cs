namespace CSharpLearning
{
    public class FullTimeEmployee : EmployeeBase, ITaxable
    {
        public decimal MonthlySalary { get; set; }

        public FullTimeEmployee() { }

        public FullTimeEmployee(string name, string department, decimal monthlySalary)
            : base(name, department)
        {
            MonthlySalary = monthlySalary;
        }

        public override decimal CalculateSalary()
        {
            return MonthlySalary;
        }

        public decimal CalculateTax()
        {
            return MonthlySalary * 0.10m;
        }
    }
}