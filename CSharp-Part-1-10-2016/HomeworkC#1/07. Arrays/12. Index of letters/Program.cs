using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Index_of_letters
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            word = word.ToLower();

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(Convert.ToInt32(word[i])-('a'));
            }


        }
    }
}
