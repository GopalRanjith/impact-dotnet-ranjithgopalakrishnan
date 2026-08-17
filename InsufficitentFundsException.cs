namespace CSharpLearning
{
    public class InsufficientFundsException : Exception
    {
        public decimal deficitamount { get; }
        public InsufficientFundsException(string message, decimal remainingamount) : base(message)
        {
            deficitamount = remainingamount;
        }
    }
}