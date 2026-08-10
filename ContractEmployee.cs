namespace CSharpLearning
{
    public class ContractEmployee : EmployeeBase
    {
        public decimal ContractAmount { get; set; }

        public ContractEmployee() { }

        public ContractEmployee(string name, string department, decimal contractAmount)
            : base(name, department)
        {
            ContractAmount = contractAmount;
        }

        public override decimal CalculateSalary()
        {
            return ContractAmount;
        }
    }
}