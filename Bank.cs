namespace CSharpLearning
{
	public class Banks
	{
		private decimal balance;
		public Banks(decimal amount)
		{
			balance = amount;

		}
		public void AmountWithdrawl(decimal withdrawlamount)
		{
			if (withdrawlamount <= balance)
			{
				balance -= withdrawlamount;
			}
			else
			{
				decimal deficitbalance = withdrawlamount - balance;
				throw new InsufficientFundsException("Insufficient funds ", deficitbalance);
			}
		}
	}
}