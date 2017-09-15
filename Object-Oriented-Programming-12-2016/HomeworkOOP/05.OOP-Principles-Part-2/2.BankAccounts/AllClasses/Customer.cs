using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccounts.AllClasses
{     
    public  class Customer
    {
        public string CustomerName { get; private set; }
        public CustomerType TypeOfCustomers { get; private set; }


        public Customer(string customerName,CustomerType typeOfCustomers)
        {
            this.CustomerName = customerName;
            this.TypeOfCustomers = typeOfCustomers;
        }
    }
}
