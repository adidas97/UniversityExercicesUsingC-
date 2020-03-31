using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class TimeDepositAccount : SavingAccount
    {
        private int periodsToMaturity;
        private const double earlyWithdrawPenalty = 20.0;

        public TimeDepositAccount(string name, double rate, int maturity) : base(name, rate)
        {
            periodsToMaturity = maturity;
        }
        public override void AddInterest()
        {
            periodsToMaturity--;
            base.AddInterest();
        }

        public override void Withdraw(double money)
        {
            if (periodsToMaturity > 0)
                base.Withdraw(earlyWithdrawPenalty);
            base.Withdraw(money);
        }
    }
}
