using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount()
            {
                AccountNumber = 1,
                MoneyRemains = 0,
                AccountType = AccountType.Debit
            };

            Console.WriteLine($"AN: {bankAccount.AccountNumber};\nAT: {bankAccount.AccountType};\nYour Money: {bankAccount.MoneyRemains}.");
        }
    }
}
