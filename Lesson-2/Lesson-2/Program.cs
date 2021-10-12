﻿using System;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(100, AccountType.Credit);
            
            Console.WriteLine(
                $"Your AN: {bankAccount.GetAccountNumber()};" +
                $"\nYour AT: {bankAccount.GetAccountType()};" +
                $"\nYour Balance: {bankAccount.GetBalance()} rub.");
        }
    }
}
