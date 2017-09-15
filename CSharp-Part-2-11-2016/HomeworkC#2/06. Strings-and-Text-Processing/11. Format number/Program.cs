using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Format_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number =42;
            Console.WriteLine(number.ToString("D").PadLeft(15, ' '));
            Console.WriteLine(number.ToString("X").PadLeft(15, ' '));

            double num = 0.3565;
            Console.WriteLine(num.ToString("P2").PadLeft(15, ' '));
            Console.WriteLine(num.ToString("E").PadLeft(15, ' '));
        }
    }
}
