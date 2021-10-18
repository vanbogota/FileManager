using System;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.SetAccountNumber(1);
            bankAccount.SetAccountType(AccountType.Debit);
            bankAccount.SetBalance(100);

            Console.WriteLine(
                $"Your AN: {bankAccount.GetAccountNumber()};" +
                $"\nYour AT: {bankAccount.GetAccountType()};" +
                $"\nYour Balance: {bankAccount.GetBalance()} rub.");
        }
    }
}
