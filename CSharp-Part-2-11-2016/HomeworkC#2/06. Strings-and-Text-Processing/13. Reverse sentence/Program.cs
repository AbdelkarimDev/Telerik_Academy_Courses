//Write a program that reverses the words in given sentence.
//Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseWordsInSentence
{
    static void Main()
    {
        string someText = "C# is, not C++, not PHP and not Delphi, i kvo ot tova?koko boko!";
        char[] separators = { ' ' };

        string[] splitted = someText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        List<char> signs = new List<char>();

        int index = 0;
        for (int i = 0; i < splitted.Length; i++)
        {
            if (splitted[i].Contains(','))
            {
                signs.Add(',');
                index = splitted[i].IndexOf(',');
                splitted[i] = splitted[i].Remove(index, 1);
            }
            else if (splitted[i].Contains('.'))
            {
                signs.Add('.');
                index = splitted[i].IndexOf('.');
                splitted[i] = splitted[i].Remove(index, 1);
            }
            else if (splitted[i].Contains('!'))
            {
                signs.Add('!');
                index = splitted[i].IndexOf('!');
                splitted[i] = splitted[i].Remove(index, 1);
            }
            else if (splitted[i].Contains('?'))
            {
                signs.Add('?');
                index = splitted[i].IndexOf('?');
                splitted[i] = splitted[i].Remove(index, 1);
            }
            else
            {
                signs.Add('*');
            }
        }

        signs.Reverse();

        StringBuilder reversedSentence = new StringBuilder();

        for (int i = splitted.Length - 1; i >= 0; i--)
        {
            reversedSentence.Append(splitted[i]);
            if (signs[i] != '*')
            {
                reversedSentence.Append(signs[i]);
            }
            if (i > 0)
            {
                reversedSentence.Append(" ");
            }

        }
        Console.WriteLine(reversedSentence);


    }
}

