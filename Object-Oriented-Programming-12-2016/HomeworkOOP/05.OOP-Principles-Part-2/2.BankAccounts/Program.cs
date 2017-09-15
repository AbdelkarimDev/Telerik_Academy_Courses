using _2.BankAccounts.AllClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccounts
{
    class Program
    {
        static void Main()
        {
            string textSeparator = new string('-', 80);
            Console.WriteLine(textSeparator);
            
            DepositAccount IvanAccount = new DepositAccount(new Customer("Ivan Ivanov", CustomerType.Individual), 500M, 4.6M);

            IvanAccount.Deposit(1150);
            IvanAccount.Withdraw(250);
            var interstDeposit= IvanAccount.CalculateInterest(13);
            IvanAccount.Deposit(interstDeposit);
            
            Console.WriteLine("Current DepositAccount balance of customer: {0} is {1:c2} ",
                IvanAccount.Customer.CustomerName, IvanAccount.Balance);
            
            Console.WriteLine(textSeparator);

            
            LoanAccount GeorgiAccount = new LoanAccount(new Customer("Georgi Petrov",CustomerType.Individual), 1000M, 4.6M);
            GeorgiAccount.Deposit(1500);
            var interstDepositOfGosho = GeorgiAccount.CalculateInterest(9);
            GeorgiAccount.Deposit(interstDeposit);
            
            Console.WriteLine("Current LoanAccount balance of customer: {0} is {1:c2} ",
                GeorgiAccount.Customer.CustomerName, GeorgiAccount.Balance);
            Console.WriteLine(textSeparator);


            MortgageAccount companyAccount = new MortgageAccount(new Customer("Maznata Mucka LTD", CustomerType.Company), 1000M, 4.6M);
            companyAccount.Deposit(1500);
            var interstDepositOfCompany = companyAccount.CalculateInterest(11);
            companyAccount.Deposit(interstDeposit);

            Console.WriteLine("Current MortgageAccount balance of customer: {0} is {1:c2} ",
                companyAccount.Customer.CustomerName, companyAccount.Balance);
            Console.WriteLine(textSeparator);

        }
    }
}
