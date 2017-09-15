using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccounts.AllClasses
{
    class LoanAccount : Accounts
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal depositInterestAmount = 0M;

            if (this.Customer.TypeOfCustomers == CustomerType.Individual)
            {
                if (months <= 3)
                {
                    depositInterestAmount = 0M;
                }
                else
                {
                    depositInterestAmount =  this.InterestRate * (months - 3);

                }
            }

            if (this.Customer.TypeOfCustomers == CustomerType.Company)
            {
                if (months <= 3)
                {
                    depositInterestAmount = 0M; 
                }
                else
                {
                    depositInterestAmount = this.InterestRate * (months - 3);
                }
            }

            Console.WriteLine("Total {2} interest for {0} months: {1:C2}", months, depositInterestAmount, GetType().Name);
            Console.WriteLine();

            return depositInterestAmount ;
        }



    }

}
