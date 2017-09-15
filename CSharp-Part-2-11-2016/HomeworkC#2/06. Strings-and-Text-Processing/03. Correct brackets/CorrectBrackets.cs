using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Correct_brackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            int countVerification = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i]=='(')
                {
                    countVerification++;
                }
                else if (expression[i] == ')')
                {
                    countVerification--;
                }
            }
            if (countVerification==0)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
          
        }
    }
}
