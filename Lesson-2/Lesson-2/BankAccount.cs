using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_2
{
    class BankAccount
    {
        int accountNumber = 0;
        decimal moneyRemains = 0;
        AccountType accountType = AccountType.Mixed;

        public void SetAccountNumber(int accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public int GetAccountNumber()
        {
            return accountNumber;
        }
        public void SetBalance(decimal money)
        {
            moneyRemains = money;
        }

        public decimal GetBalance()
        {
            return moneyRemains;
        }
        public void SetAccountType(AccountType accountType)
        {
            this.accountType = accountType;
        }
        public AccountType GetAccountType()
        {
            return accountType;
        }
    }
}
