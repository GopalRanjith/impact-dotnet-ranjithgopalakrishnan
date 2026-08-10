namespace CSharpLearning
{
    public class StudentGeneric
    {
        public string Name { get; set; } = "";
        public int Age { get; set; }

        public StudentGeneric() { }

        public StudentGeneric(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Student: {Name}, Age: {Age}";
        }
    }
}