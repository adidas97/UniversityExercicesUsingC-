using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class CheckingAccount : BankAccount
    {


        private const int freeTransactions = 3;
        private const double transactionFee = 2.0;
        private int transactionCount;
        public CheckingAccount(string name, double initialBalance) : base(name, initialBalance)
        {
            transactionCount = 0;
        }

        public override void Deposit(double money)
        {
            transactionCount++;
            base.Deposit(money);
        }        override public void Withdraw(double money)
        {
            transactionCount++;
            base.Withdraw(money);
        }

        private void DeductFees()
        {
            if (transactionCount > freeTransactions)
            {
                double fees = transactionFee *
                (transactionCount - freeTransactions);
                base.Withdraw(fees);
            }
            transactionCount = 0;
        }
        public override double EndOfMonth()
        {
            DeductFees();
            return Balance;
        }

    }
}
