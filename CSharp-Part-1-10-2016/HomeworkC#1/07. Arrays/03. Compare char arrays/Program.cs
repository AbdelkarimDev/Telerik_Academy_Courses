using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Compare_char_arrays
{
    class Program
    {
        static void Main()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();


            int c = string.Compare(str1,str2);

            if (c==0)
            {
                Console.WriteLine("=");
            }
            else if (c==1)
            {
                Console.WriteLine(">");
            }
            else
            {
                Console.WriteLine("<");
            }
                     

        }
    }
}


