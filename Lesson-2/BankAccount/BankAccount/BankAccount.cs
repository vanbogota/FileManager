using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class BankAccount
    {
        private static int _iterator = 0;
        private int _accountNumber;
        private readonly decimal _moneyRemains;
        private readonly AccountType _accountType;

        public BankAccount(decimal balance)
        {
            CreateAccountNumber();
            _moneyRemains = balance;
        }

        public BankAccount(AccountType accountType)
        {
            CreateAccountNumber();
            _accountType = accountType;
        }

        public BankAccount(decimal balance, AccountType accountType)
        {
            CreateAccountNumber();
            _moneyRemains = balance;
            _accountType = accountType;
        }

        public void CreateAccountNumber()
        {
            _accountNumber = _iterator;
            _iterator++;
        }        
    }
}
