using System;


namespace _02.CompanyInfo
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Company name:");
            string CompanyName = Console.ReadLine();
            //Console.WriteLine("Company address:");
            string CompanyAddress = Console.ReadLine();
            //Console.WriteLine("Phone number:");
            string PhoneNumber = Console.ReadLine();
            //Console.WriteLine("Fax number:");
            string FaxNumber = Console.ReadLine();
            //Console.WriteLine("Web site:");
            string WebSite = Console.ReadLine();
            //Console.WriteLine("Manager first name:");
            string FirstName = Console.ReadLine();
            //Console.WriteLine("Manager last name:");
            string LastName = Console.ReadLine();
            //Console.WriteLine("Manager age:");
            byte age = byte.Parse(Console.ReadLine());
            //Console.WriteLine("Manager phone:");
            string ManagerPhone = Console.ReadLine();

            Console.WriteLine(CompanyName);
            Console.WriteLine("Address: {0}", CompanyAddress);
            Console.WriteLine("Tel. {0}", PhoneNumber);
            if (FaxNumber == String.Empty)
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: {0} ", FaxNumber);
            }
            Console.WriteLine("Web site: {0}", WebSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", FirstName, LastName, age, ManagerPhone);
        }
    }
}
