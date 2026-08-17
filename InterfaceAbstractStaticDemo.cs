using System;

//
// INTERFACE vs ABSTRACT CLASS
//
// Interface:
// - A class can implement multiple interfaces.
// - Mainly defines a contract/capability.
// - Traditionally does not hold instance state.
// - Has no instance constructor.
// - Good when unrelated classes need the same behavior.
// - Example: IPrintable implemented by Invoice, Report, Receipt.
//
// Abstract class:
// - A class can inherit from only one class.
// - Can contain fields, properties, state, constructors,
//   concrete methods and abstract methods.
// - Good when related classes share common state and behavior.
// - Example: Employee -> FullTimeEmployee, PartTimeEmployee.
//
// Scenario favouring interface:
// Different unrelated classes need the same capability.
// Example: Car, Invoice and Report can all implement IPrintable.
//
// Scenario favouring abstract class:
// Different types belong to the same family and share state/logic.
// Example: Employee -> FullTimeEmployee and PartTimeEmployee.
//
// Versioning:
// Interfaces are contracts shared with implementers, so adding
// new required members can affect existing implementations.
// Abstract classes can provide shared implementation and can
// sometimes add functionality without forcing every derived
// class to implement a new abstract member.
//

// ==========================================
// Interface scenario
// ==========================================

public interface IPrintable
{
    void Print();
}

public class PrintableInvoice : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Printing invoice.");
    }
}

public class PrintableReport : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Printing report.");
    }
}


// ==========================================
// Abstract class scenario
// ==========================================

public abstract class OrderBase
{
    protected decimal Amount;

    protected OrderBase(decimal amount)
    {
        Amount = amount;
    }

    public void DisplayAmount()
    {
        Console.WriteLine($"Order amount: {Amount}");
    }

    public abstract void ProcessOrder();
}

public class OnlineOrder : OrderBase
{
    public OnlineOrder(decimal amount)
        : base(amount)
    {
    }

    public override void ProcessOrder()
    {
        Console.WriteLine("Processing online order.");
    }
}


// ==========================================
// MathHelper
// ==========================================

public static class MathHelper
{
    // Static because the calculation does not depend
    // on any MathHelper object/state.

    public static long Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException(
                "Factorial requires a non-negative number.");
        }

        long result = 1;

        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }

    public static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static int GCD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }

        return a;
    }
}


// ==========================================
// OrderProcessor
// ==========================================

public class OrderProcessor
{
    private string processorName;

    public OrderProcessor(string processorName)
    {
        this.processorName = processorName;
    }

    // Instance method because it uses the object's state:
    // processorName.

    public void ProcessOrder(string orderId)
    {
        Console.WriteLine(
            $"{processorName} processed order {orderId}.");
    }

    public void CancelOrder(string orderId)
    {
        Console.WriteLine(
            $"{processorName} cancelled order {orderId}.");
    }
}