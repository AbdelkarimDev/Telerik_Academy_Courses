using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccounts.AllClasses
{
    class MortgageAccount : Accounts
    {

        public MortgageAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }




        public override decimal CalculateInterest(int months)
        {
            decimal depositInterestAmount = 0M;


            if (this.Customer.TypeOfCustomers == CustomerType.Individual)
            {
                if (months <= 6)
                {
                    depositInterestAmount = 0M;
                }
                else
                {
                    depositInterestAmount =  this.InterestRate * (months - 6);
                }
            }

            if (this.Customer.TypeOfCustomers == CustomerType.Company)
            {
                if (months <= 12)
                {
                    depositInterestAmount =  (this.InterestRate *months )/2;
                }
                else
                {
                    depositInterestAmount =  ((this.InterestRate * 12) / 2)+(base.CalculateInterest(months - 12));
                }
            }
            Console.WriteLine("Total {2} interest for {0} months: {1:C2}", months, depositInterestAmount, GetType().Name);
            Console.WriteLine();

            return depositInterestAmount;
        }


    }

}
