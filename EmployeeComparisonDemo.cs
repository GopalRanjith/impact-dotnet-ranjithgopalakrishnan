using System;
using System.Collections.Generic;

// ==========================================
// Employee
// ==========================================

public class ComparableEmployee : IComparable<ComparableEmployee>
{
    public string Name { get; set; } = "";
    public decimal Salary { get; set; }

    // Default Sort() will use this comparison.
    // Employees are sorted by Salary.
    public int CompareTo(ComparableEmployee? other)
    {
        if (other == null)
        {
            return 1;
        }

        return Salary.CompareTo(other.Salary);
    }

    public override string ToString()
    {
        return $"{Name} - {Salary}";
    }
}


// ==========================================
// Custom Comparer - Sort by Name
// ==========================================

public class EmployeeNameComparer : IComparer<ComparableEmployee>
{
    public int Compare(
        ComparableEmployee? x,
        ComparableEmployee? y)
    {
        if (x == null && y == null)
            return 0;

        if (x == null)
            return -1;

        if (y == null)
            return 1;

        return string.Compare(
            x.Name,
            y.Name,
            StringComparison.OrdinalIgnoreCase);
    }
}


// ==========================================
// Demo
// ==========================================

public static class EmployeeComparisonDemo
{
    public static void Run()
    {
        List<ComparableEmployee> employees =
            new List<ComparableEmployee>
            {
                new ComparableEmployee
                {
                    Name = "Ranjith",
                    Salary = 65000
                },

                new ComparableEmployee
                {
                    Name = "Arun",
                    Salary = 55000
                },

                new ComparableEmployee
                {
                    Name = "Karthik",
                    Salary = 72000
                },

                new ComparableEmployee
                {
                    Name = "Bala",
                    Salary = 48000
                },

                new ComparableEmployee
                {
                    Name = "Deepak",
                    Salary = 90000
                },

                new ComparableEmployee
                {
                    Name = "Sanjay",
                    Salary = 60000
                },

                new ComparableEmployee
                {
                    Name = "Vijay",
                    Salary = 75000
                },

                new ComparableEmployee
                {
                    Name = "Ajay",
                    Salary = 52000
                },

                new ComparableEmployee
                {
                    Name = "Manoj",
                    Salary = 68000
                },

                new ComparableEmployee
                {
                    Name = "Prakash",
                    Salary = 58000
                }
            };


        // ==========================================
        // Default Sort() -> Salary
        // ==========================================

        employees.Sort();

        Console.WriteLine("Sorted by Salary:");

        foreach (ComparableEmployee employee in employees)
        {
            Console.WriteLine(employee);
        }


        // ==========================================
        // Custom Comparer -> Name
        // ==========================================

        employees.Sort(new EmployeeNameComparer());

        Console.WriteLine("\nSorted by Name:");

        foreach (ComparableEmployee employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
}