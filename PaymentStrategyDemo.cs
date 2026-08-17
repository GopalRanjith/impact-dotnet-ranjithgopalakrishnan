using System;

// ==========================================
// Strategy Interface
// ==========================================

public interface IPaymentStrategy
{
    void Pay(decimal amount);
}


// ==========================================
// Concrete Strategies
// ==========================================

public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine(
            $"Paid {amount:C} using Credit Card.");
    }
}

public class UpiPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine(
            $"Paid {amount:C} using UPI.");
    }
}

public class NetBankingPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine(
            $"Paid {amount:C} using Net Banking.");
    }
}


// ==========================================
// Shopping Cart
// ==========================================

public class ShoppingCart
{
    private IPaymentStrategy paymentStrategy;

    public ShoppingCart(IPaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public void SetPaymentStrategy(IPaymentStrategy strategy)
    {
        paymentStrategy = strategy;
    }

    public void Checkout(decimal amount)
    {
        paymentStrategy.Pay(amount);
    }
}