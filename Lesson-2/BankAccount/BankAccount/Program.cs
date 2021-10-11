using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = 100;
            var accountType = AccountType.Credit;
            BankAccount bankAccount1 = new BankAccount(money);
            BankAccount bankAccount2 = new BankAccount(accountType);
            BankAccount bankAccount3 = new BankAccount(money, accountType);

            Console.WriteLine("Сейчас нечего вывести");
        }
    }
}
