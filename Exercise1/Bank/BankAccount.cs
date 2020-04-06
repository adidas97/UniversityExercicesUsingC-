using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class BankAccount
    {
        private int accountNumber;
        private static int lastAssignedNumber = 0;
        private string name;
        private double balance;
        public double Balance
        {
            get
            {
                return balance;
            }
        }

        public BankAccount(string n, double initialBalance)
        {
            name = n;
            lastAssignedNumber++;
            accountNumber = lastAssignedNumber;
            balance = initialBalance;
        }

        public BankAccount(string n) : this(n, 0)
        {
        }

        public virtual void Deposit(double money)
        {
            balance += money;
        }

        public virtual void Withdraw(double money)
        {
            if (money <= balance)
                balance -= money;
        }        public void Transfer(BankAccount other, double money)
        {
            Withdraw(money);
            other.Deposit(money);
        }        public virtual double EndOfMonth()
        {
            return balance;
        }        public override string ToString()
        {
            return String.Format("{0} \t {1} \t {2,20:F2} BGN",
            accountNumber, name, balance);
        }        public override int GetHashCode()
        {
            return accountNumber.GetHashCode() ^ name.GetHashCode();
        }        public override bool Equals(Object obj)
        {
          // if (obj == null)
          // {
          //     return false;
          // }
            BankAccount account = obj as BankAccount;
            if ((System.Object)account == null)
            {
                return false;
            }
            return (account.balance == balance);
        }

        public static bool operator ==(BankAccount a1, BankAccount a2)
        {
            if ((Object)a1 == null)
                return false;
            return a1.Equals(a2);
        }
        public static bool operator !=(BankAccount a1, BankAccount a2)
        {
            if ((Object)a1 == null)
                return true;
            return !a1.Equals(a2);
        }
    }

}

