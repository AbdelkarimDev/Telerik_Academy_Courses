using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba
{
    class Program
    {

        // Find all occurrences of a word within a text and return the indices of the occurrences
        static List<int> FindOccurrences(string text, string word)
        {
            var occurrences = new List<int>();

            int indexOfNextPatern = text.IndexOf(word);

            while (indexOfNextPatern != -1)
            {
                occurrences.Add(indexOfNextPatern);
                indexOfNextPatern = text.IndexOf(word, indexOfNextPatern + 1);
            }

            return occurrences;
        }

        static void Main()
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();
            int countPattern = 0;
            var coincides = FindOccurrences(text, pattern);

            foreach (var coincide in coincides)
            {
                countPattern++;
            }
            Console.WriteLine(countPattern);
        }
    }
}



//string example = @"We are living in a <upcase>yellow submarine</upcase>.We don't have <upcase>anything</upcase> else. Lala <upcase>la la la</upcase>.";
//Console.WriteLine("example before changes:\n{0}\n", example);

//        int start = 0;
//int end = 0;
//StringBuilder buffer = new StringBuilder();

//start = example.IndexOf("<upcase>");
//        end = example.IndexOf("</upcase>");


//     //   if (start != -1)
//       // {
//            while (start != -1)
//            {
//                if (end == -1)
//                {
//                    break;
//                }
//                for (int i = start + 8; i<end; i++)
//                {
//                    buffer.Append(example[i]);
//                }
//                example = example.Remove(start, (end - start + 9));
//                example = example.Insert(start, buffer.ToString().ToUpper());
//                buffer.Clear();
//                start = example.IndexOf("<upcase>", start + 1);
//                if (start == -1)
//                {
//                    break;
//                }
//                end = example.IndexOf("</upcase>", end + 1);
//            }
//      //  }
//        Console.WriteLine("example after changes:\n{0}\n", example);