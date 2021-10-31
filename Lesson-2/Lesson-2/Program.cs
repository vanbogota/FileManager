using System;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(100, AccountType.Credit);
            
            //Console.WriteLine(
            //    $"Your AN: {bankAccount.AccountNumber};" +
            //    $"\nYour AT: {bankAccount.AccountType};" +
            //    $"\nYour Balance: {bankAccount.MoneyRemains} rub.");

            Console.WriteLine(bankAccount.ForwardString("qwerty"));
        }

    }
}
