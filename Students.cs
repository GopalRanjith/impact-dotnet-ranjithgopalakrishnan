using System;

namespace SchoolManagement
{
    public class Students
    {
        // const
        public const string SchoolName = "ABC Public School";

        // readonly
        public readonly DateTime AdmissionDate;

        private int age;

        public string Name { get; set; }

        // Validated Property
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 5 && value <= 100)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Invalid Age! Age should be between 5 and 100.");
                }
            }
        }

        // Default Constructor
        public Students()
        {
            AdmissionDate = DateTime.Now;
        }

        // Parameterized Constructor
        public Students(string name, int age) : this()
        {
            Name = name;
            Age = age;
        }

        // Constructor Chaining
        public Students(string name, int age, DateTime admissionDate)
            : this(name, age)
        {
            AdmissionDate = admissionDate;
        }

        // Method Overloading
        public string CalculateGrade(int marks)
        {
            return marks >= 50 ? "Pass" : "Fail";
        }

        public string CalculateGrade(int marks, int totalMarks)
        {
            double percentage = (double)marks / totalMarks * 100;

            if (percentage >= 90)
                return "A";
            else if (percentage >= 75)
                return "B";
            else if (percentage >= 60)
                return "C";
            else
                return "Fail";
        }
    }
}