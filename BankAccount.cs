using System;
using System.Collections.Generic;

namespace Bank
{
    public class BankAccount
    {
        private decimal balance;
        private List<string> history = new List<string> ();

        public void Deposit(decimal amount )
        {
            if(amount<=0)
            {
                history.Add($"Deposit failed: {amount}");
                Console.WriteLine("Deposit amount must be greater than 0.");
                return;
            }
            balance += amount;
            history.Add($"Deposited : {amount}");
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                history.Add($"Withdrawal failed: {amount}");
                Console.WriteLine("Withdrawal amount must be greater than 0.");
                return;
            }

            if (amount > balance)
            {
                history.Add($"Withdrawal failed: insufficient balance ({amount})");
                Console.WriteLine("Insufficient balance.");
                return;
            }

            balance -= amount;
            history.Add($"Withdrew: {amount}");
        }
        public decimal GetBalance()
        {
            return balance;
        }
        public void PrintHistory()
        {
            Console.WriteLine("Transaction History:");

            foreach (string item in history)
            {
                Console.WriteLine(item);
            }
        }
    }
}