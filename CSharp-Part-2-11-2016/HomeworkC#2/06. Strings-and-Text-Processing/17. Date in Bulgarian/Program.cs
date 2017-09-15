using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Date_in_Bulgarian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding =Encoding.UTF8;

            Console.WriteLine("Enter date and time in format \"day.month.year hour:minutes:seconds\":");
            DateTime now=DateTime.Now;
            DateTime dateAndTime = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy H:m:s", CultureInfo.CurrentUICulture);
            CultureInfo bgCulture = new CultureInfo("bg-BG");
          
            TimeSpan time = new TimeSpan(0, 6, 30, 0);
            DateTime combined = dateAndTime.Add(time);
            
            Console.WriteLine(combined.ToString("dddd dd.MM.yyyy H:m:s", bgCulture));

            //string uk = myDate.ToString(new CultureInfo("en-GB"))

        }
    }
}
