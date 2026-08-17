using System;
using System.Reflection;

// ==========================================
// Custom MaxLength Attribute
// ==========================================

[AttributeUsage(AttributeTargets.Property)]
public class MaxLengthAttribute : Attribute
{
    public int Length { get; }

    public MaxLengthAttribute(int length)
    {
        Length = length;
    }
}


// ==========================================
// User class
// ==========================================

public class AttributeUser
{
    [MaxLength(10)]
    public string Name { get; set; } = "";

    public string Email { get; set; } = "";
}


// ==========================================
// Reflection-based Validator
// ==========================================

public static class AttributeValidator
{
    public static void Validate(object obj)
    {
        Type type = obj.GetType();

        foreach (PropertyInfo property in type.GetProperties())
        {
            // Only check string properties
            if (property.PropertyType != typeof(string))
            {
                continue;
            }

            MaxLengthAttribute? attribute =
                property.GetCustomAttribute<MaxLengthAttribute>();

            if (attribute == null)
            {
                continue;
            }

            string? value =
                property.GetValue(obj) as string;

            if (value != null &&
                value.Length > attribute.Length)
            {
                Console.WriteLine(
                    $"Warning: {property.Name} exceeds " +
                    $"maximum length of {attribute.Length}. " +
                    $"Actual length: {value.Length}");
            }
            else
            {
                Console.WriteLine(
                    $"{property.Name} is valid.");
            }
        }
    }
}