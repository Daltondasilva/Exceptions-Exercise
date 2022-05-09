using System;
using Exercicio155.Entities;
using Exercicio155.Entities.Exceptions;

namespace Exercicio155
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                Account account = new Account();

                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial Balance: $");
                double inBalance = double.Parse(Console.ReadLine());

                account.Deposit(inBalance);

                Console.Write("Withdraw Limit: $");
                double wtdLimit = double.Parse(Console.ReadLine());

                account.WithdrawLimit = wtdLimit;

                Console.WriteLine();
                Console.Write("Enter the amount for withdrawal: $");
                double withdrawal = double.Parse(Console.ReadLine());

                account.Withdraw(withdrawal);

                Console.WriteLine(account);
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
