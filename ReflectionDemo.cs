using System;
using System.Reflection;

// ==========================================
// Invoice class
// ==========================================

public class ReflectionInvoice
{
    public int Id { get; set; }

    public string CustomerName { get; set; } = "";

    public decimal Amount { get; set; }

    public ReflectionInvoice()
    {
    }

    public ReflectionInvoice(int id, string customerName, decimal amount)
    {
        Id = id;
        CustomerName = customerName;
        Amount = amount;
    }

    public void PrintInvoice()
    {
        Console.WriteLine(
            $"Invoice: {Id}, Customer: {CustomerName}, Amount: {Amount}");
    }

    public void CalculateTax()
    {
        Console.WriteLine($"Tax: {Amount * 0.18m}");
    }
}


// ==========================================
// Reflection Demo
// ==========================================

public class ReflectionDemo
{
    public static void Run()
    {
        Type type = typeof(ReflectionInvoice);

        // ==========================================
        // Class name
        // ==========================================

        Console.WriteLine(
            $"Class Name: {type.Name}");


        // ==========================================
        // Properties + Types
        // ==========================================

        Console.WriteLine("\nProperties:");

        foreach (PropertyInfo property in type.GetProperties())
        {
            Console.WriteLine(
                $"{property.Name} : {property.PropertyType.Name}");
        }


        // ==========================================
        // Methods
        // ==========================================

        Console.WriteLine("\nMethods:");

        foreach (MethodInfo method in type.GetMethods())
        {
            Console.WriteLine(method.Name);
        }


        // ==========================================
        // Constructors + Parameters
        // ==========================================

        Console.WriteLine("\nConstructors:");

        foreach (ConstructorInfo constructor
                 in type.GetConstructors())
        {
            Console.Write($"{constructor.Name}(");

            ParameterInfo[] parameters =
                constructor.GetParameters();

            for (int i = 0; i < parameters.Length; i++)
            {
                Console.Write(
                    $"{parameters[i].ParameterType.Name} " +
                    $"{parameters[i].Name}");

                if (i < parameters.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine(")");
        }


        // ==========================================
        // Create object using reflection
        // ==========================================

        object? invoice =
            Activator.CreateInstance(type);

        Console.WriteLine(
            $"\nCreated object: {invoice != null}");


        // ==========================================
        // Set property using reflection
        // ==========================================

        PropertyInfo? customerProperty =
            type.GetProperty("CustomerName");

        customerProperty?.SetValue(
            invoice,
            "Ranjith");


        PropertyInfo? amountProperty =
            type.GetProperty("Amount");

        amountProperty?.SetValue(
            invoice,
            75000m);


        PropertyInfo? idProperty =
            type.GetProperty("Id");

        idProperty?.SetValue(
            invoice,
            101);


        // ==========================================
        // Verify
        // ==========================================

        Console.WriteLine("\nValues after reflection:");

        Console.WriteLine(
            $"Id: {idProperty?.GetValue(invoice)}");

        Console.WriteLine(
            $"Customer: {customerProperty?.GetValue(invoice)}");

        Console.WriteLine(
            $"Amount: {amountProperty?.GetValue(invoice)}");
    }
}