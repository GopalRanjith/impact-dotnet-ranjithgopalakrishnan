namespace CSharpLearning
{
    public abstract class EmployeeBase
    {
        public string Name { get; set; } = "";
        public string Department { get; set; } = "";

        protected EmployeeBase() { }

        protected EmployeeBase(string name, string department)
        {
            Name = name;
            Department = department;
        }

        public abstract decimal CalculateSalary();
    }
}