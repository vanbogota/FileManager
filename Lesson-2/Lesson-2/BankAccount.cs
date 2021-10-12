using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_2
{
    class BankAccount
    {
        static int index = 0;
        int accountNumber = 0;
        decimal moneyRemains = 0;
        AccountType accountType = AccountType.Mixed;

        public BankAccount(decimal balance)
        {
            CreateAccount();
            moneyRemains = balance;
        }

        public BankAccount(AccountType accountType)
        {
            CreateAccount();
            this.accountType = accountType;
        }

        public BankAccount(decimal balance, AccountType accountType)
        {
            CreateAccount();
            moneyRemains = balance;
            this.accountType = accountType;
        }

        public void CreateAccount()
        {
            accountNumber = index;
            index++;
        }
        
    }
}
