using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubStringInTextoba
{
    class SubStringInText
    {

        // Find all occurrences of a word within a text and return the indices of the occurrences
        static int FindOccurrences(string text, string word)
        {
           int occurrences = 0;

            int indexOfNextPatern = text.IndexOf(word, StringComparison.CurrentCultureIgnoreCase);

            while (indexOfNextPatern != -1)
            {
                occurrences++;
                indexOfNextPatern = text.IndexOf(word, indexOfNextPatern + 1, StringComparison.CurrentCultureIgnoreCase);
            }

            return occurrences;
        }

        static void Main()
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();
            text = text.ToLower();
            Console.WriteLine(FindOccurrences(text, pattern)); 

           
        }
    }
}
