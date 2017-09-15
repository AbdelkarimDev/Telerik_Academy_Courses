using _2.BankAccounts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///customer, balance and interest rate

namespace _2.BankAccounts.AllClasses
{
    public abstract class Accounts : IDepositable

    {
        public Customer Customer { get; private set; }
        public decimal Balance { get; protected set; }
        public decimal InterestRate { get; private set; }
    


        protected Accounts(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }


        public virtual decimal CalculateInterest(int months)
        {
            return this.InterestRate * months;
        }


        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Invalid deposit amount!");
            }

            this.Balance += amount;
        }
    }



   
}

