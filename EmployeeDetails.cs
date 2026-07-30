namespace CSharpLearning
{
    public partial class Employee
    {
        public string Name { get; set; }

        partial void ShowDepartment()
        {
            Console.WriteLine("Department : IT");
        }
    }
}