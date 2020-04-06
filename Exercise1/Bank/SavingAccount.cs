using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class SavingAccount : BankAccount
    {
        private double interestRate;        public SavingAccount(string name, double rate) : base(name)
        {
            interestRate = rate;
        }
        public virtual void AddInterest()
        {
            double interest = Balance * interestRate / 100;
            Deposit(interest);
        }
        public override double EndOfMonth()
        {
            AddInterest();
            return Balance;
        }
    }
}
