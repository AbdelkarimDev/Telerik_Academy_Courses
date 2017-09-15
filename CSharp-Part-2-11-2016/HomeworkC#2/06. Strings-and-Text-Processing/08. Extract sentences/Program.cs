using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Extract_sentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] text = Console.ReadLine().Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder newtext = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {

                //int a = text[i].Contains(word);
                if (text[i].Contains(" "+word+" "))
                {
                    newtext.Append(text[i]);
                    newtext.Append('.');

                }
            }
            Console.WriteLine(newtext);
        }
    }
}
