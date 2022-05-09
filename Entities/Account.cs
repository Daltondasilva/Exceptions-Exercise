using Exercicio155.Entities.Exceptions;

namespace Exercicio155.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance < amount)
            {
                throw new DomainException("Error: Cannot withdraw greater amount than the current balance.");
            }
            if (WithdrawLimit < amount)
            {
                throw new DomainException("Error: Cannot withdraw greater amount than the Withdraw Limit.");
            }
            else
            {
                Balance -= amount;
            }
        }

        public override string ToString()
        {
            return "New balance: $"
                + Balance;
        }
    }
}
