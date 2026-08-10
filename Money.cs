using System;

namespace CSharpLearning
{
    public class Money
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        // + operator
        public static Money operator +(Money a, Money b)
        {
            if (a.Currency != b.Currency)
                throw new InvalidOperationException("Cannot add different currencies.");

            return new Money(a.Amount + b.Amount, a.Currency);
        }

        // == operator
        public static bool operator ==(Money a, Money b)
        {
            if (ReferenceEquals(a, b))
                return true;

            if (a is null || b is null)
                return false;

            return a.Amount == b.Amount && a.Currency == b.Currency;
        }

        // != operator
        public static bool operator !=(Money a, Money b)
        {
            return !(a == b);
        }

        // > operator
        public static bool operator >(Money a, Money b)
        {
            if (a.Currency != b.Currency)
                throw new InvalidOperationException("Cannot compare different currencies.");

            return a.Amount > b.Amount;
        }

        // < operator
        public static bool operator <(Money a, Money b)
        {
            if (a.Currency != b.Currency)
                throw new InvalidOperationException("Cannot compare different currencies.");

            return a.Amount < b.Amount;
        }

        public override string ToString()
        {
            return $"{Amount} {Currency}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Money other)
                return this == other;

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Amount, Currency);
        }
    }
}