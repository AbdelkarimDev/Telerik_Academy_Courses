using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Decimal_to_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            string output = "";

            do
            {
                output = (input % 2 == 0 ? "0" : "1") + output;
                input /= 2;
            } while (input != 0);

            Console.WriteLine(output);
        }
    }
}
