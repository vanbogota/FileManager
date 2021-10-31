using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_2
{
    public class BankAccount
    {
        
        public int AccountNumber { get; set; } = 0;
        public decimal MoneyRemains { get; set; } = 0;
        public AccountType AccountType { get; set; } = AccountType.Mixed;
        static int Index { get; set; } = 1;
        public BankAccount(decimal balance)
        {
            CreateAccount();
            MoneyRemains = balance;
        }
        
        public BankAccount(AccountType accountType)
        {
            CreateAccount();
            AccountType = accountType;
        }

        public BankAccount(decimal balance, AccountType accountType)
        {
            CreateAccount();
            MoneyRemains = balance;
            AccountType = accountType;
        }

        public void CreateAccount()
        {
            AccountNumber = Index;
            Index++;
        }
        
        public void GetMoney(decimal summToDiscard)
        {
            if (summToDiscard <= MoneyRemains)
            {
                MoneyRemains -= summToDiscard;
            }
            else
            {
                Console.WriteLine("You don't have enough money");
            }           
        }
        
        public void PushMoney(decimal moneyIncome)
        {
            MoneyRemains += moneyIncome;
        }
        public void TransactionIn(BankAccount fromAccount, decimal money)
        {
            if (fromAccount.MoneyRemains >= money
                || fromAccount.AccountType == AccountType.Credit
                || fromAccount.AccountType == AccountType.Mixed)
            {
                fromAccount.MoneyRemains -= money;
                MoneyRemains += money;
            }
            else
            {
                throw new Exception("Invalid operation. Not enough money.");
            }
        }
        
        public string ForwardString(string str)
        {
            string newStr = null;
            for (int i = str.Length-1; i >= 0; i--)
            {
                newStr += str[i];
            }
            return newStr;
        }
    }
}
