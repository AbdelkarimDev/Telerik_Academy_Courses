using _2.BankAccounts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccounts.AllClasses
{
    class DepositAccount : Accounts, IWithdrawingMoney
    {
        private const decimal MinimalDepositValue = 1000m;


        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }


        public void Withdraw(decimal amount)
        {
            if (this.Balance < amount)
            {
                throw new ApplicationException("Not enough money available.");
            }

            this.Balance -= amount;
        }


        public override decimal CalculateInterest(int months)
        {
            decimal depositInterestAmount =0M;
            if (this.Balance < MinimalDepositValue)
            {
                return 0M;
            }
            else
            {
                depositInterestAmount = base.CalculateInterest(months);
            }

            Console.WriteLine("Total {2} interest for {0} months: {1:C2}", months, depositInterestAmount,GetType().Name );
            Console.WriteLine();

            return depositInterestAmount ;

        }
    }
}
