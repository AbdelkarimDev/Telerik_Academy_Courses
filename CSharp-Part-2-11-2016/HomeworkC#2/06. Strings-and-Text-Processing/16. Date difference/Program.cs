using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Date_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first date in format \"day.month.year\":");
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d*M*yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Enter second date in format DD.MM.YYYY:");
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);

            TimeSpan span = secondDate - firstDate;
            Console.WriteLine("{0} days", span.Days);
        }
    }
}
