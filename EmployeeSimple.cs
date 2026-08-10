namespace CSharpLearning
{
    public class EmployeeSimple
    {
        public string Name { get; set; } = "";
        public decimal Salary { get; set; }

        public EmployeeSimple() { }

        public EmployeeSimple(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}