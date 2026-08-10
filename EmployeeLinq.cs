using System;

namespace CSharpLearning
{
    public class EmployeeLinq
    {
        public string Name { get; set; } = "";
        public string Department { get; set; } = "";
        public decimal Salary { get; set; }
        public DateTime JoiningDate { get; set; }

        public EmployeeLinq() { }

        public EmployeeLinq(string name, string department, decimal salary, DateTime joiningDate)
        {
            Name = name;
            Department = department;
            Salary = salary;
            JoiningDate = joiningDate;
        }
    }
}