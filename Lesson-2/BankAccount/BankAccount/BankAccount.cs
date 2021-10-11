﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class BankAccount
    {
        public static int _iterator = 0;
        public int AccountNumber
        {
            get
            {
                return _accountNumber;   
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Can't be less then 0");
                }
                else
                {
                    _accountNumber = value;
                }
            }
        }
        
        public decimal MoneyRemains
        {
            get
            {
                return _moneyRemains;
            }
            set
            {
                _moneyRemains = value;
            } 
        }
        public AccountType AccountType
        {
            get
            {
                return _accountType;
            }
            set
            {
                _accountType = value;
            }
        }

        public void CreateAccountNumber()
        {
            _accountNumber = _iterator;
            _iterator++;
        }

        private int _accountNumber;
        private decimal _moneyRemains;
        private AccountType _accountType;
    }
}