﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class BankAccount
    {
        // Balance of the account; must not become negative
        private double balance;

        // Interest rate of the account; must be between 0.0 and 20.0
        private double interestRate;


        public BankAccount(double interestRate)
        {
            this.interestRate = interestRate;
            this.balance = 0.0;
        }

        public void Deposit(double amount)
        {
            balance = balance + amount;
        }

        public void Withdraw(double amount)
        {
            if (balance < amount)
            {
                throw new WithdrawAmountTooLargeException();
            }

            balance = balance - amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}