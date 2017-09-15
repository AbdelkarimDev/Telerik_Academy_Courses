using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputdata = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < inputdata.Length; i++)
            {
                sum += inputdata[i];
            }
            Console.WriteLine(sum);

        }
    }
}

//variant 2

//       string myStr = Console.ReadLine();
//int sum = 0;
//string[] myArr = myStr.Split(' ');
//            foreach (var item in myArr)
//            {
//                sum += int.Parse(item);
//            }
//            Console.WriteLine(sum);

//    variant 3

//    char[] separators = { ' ' };

//string numbers = Console.ReadLine();
//Console.WriteLine("Numbers to sum: {0}\nTotal sum:", numbers);

//        string[] values = numbers.Split(separators, StringSplitOptions.RemoveEmptyEntries);

//int sum = 0;
//        foreach (string str in values)
//        {
//            sum += int.Parse(str);            
//        }
//        Console.WriteLine(sum);
