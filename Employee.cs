namespace CSharpLearning
{
    public partial class Employee
    {
        public int Id { get; set; }

        partial void ShowDepartment();

        public void Display()
        {
            Console.WriteLine($"Employee Id : {Id}");
            ShowDepartment();
        }
    }
}