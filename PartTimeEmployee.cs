namespace CSharpLearning
{
    public class PartTimeEmployee : EmployeeBase
    {
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }

        public PartTimeEmployee() { }

        public PartTimeEmployee(string name, string department, int hoursWorked, decimal hourlyRate)
            : base(name, department)
        {
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
        }

        public override decimal CalculateSalary()
        {
            return HoursWorked * HourlyRate;
        }
    }
}