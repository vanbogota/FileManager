using System;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount(100, AccountType.Credit);
            BankAccount bankAccount2 = new BankAccount(100, AccountType.Credit);
                        
            //Testing BankAccount
            Console.WriteLine(bankAccount1.ToString());
            Console.WriteLine(bankAccount1.GetHashCode());
            Console.WriteLine(bankAccount2.ToString());
            Console.WriteLine(bankAccount2.GetHashCode());
            Console.WriteLine(bankAccount1.Equals(bankAccount2));
        }

    }
}
