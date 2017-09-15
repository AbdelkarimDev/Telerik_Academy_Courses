
//Problem 5. Sort by string length

//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

namespace Problem05SortByStringLength
{
    class SortByStringLength
    {
        static void Main()
        {
            Console.WriteLine("N= ");
            int n = int.Parse(Console.ReadLine());

            string[] array = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter array[{0}]: ", i);
                array[i] = Console.ReadLine();
            }

            // Sort with lambda
            Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Array[{0}] = {1} ", i, array[i]);
            }
        }
    }
}













//using System;

//class SortMatrixOfStrings
//{
//    static void Main()
//    {
//        string[] arrayOfStrings =
//        {
//            "123456",
//            "0",
//            "1235",
//            "1234567891012",
//            "",
//            "01"
//        };
//        Console.WriteLine("Before sorting:");
//        Print(arrayOfStrings);
//        Console.WriteLine("".PadLeft(64, '*'));

//        string temp = "";

//        for (int i = 0; i < arrayOfStrings.Length; i++)
//        {
//            for (int k = i + 1; k < arrayOfStrings.Length; k++)
//            {
//                if (arrayOfStrings[k].Length <= arrayOfStrings[i].Length)
//                {
//                    temp = arrayOfStrings[k];
//                    arrayOfStrings[k] = arrayOfStrings[i];
//                    arrayOfStrings[i] = temp;
//                }
//            }
//        }
//        Console.WriteLine("After sorting:");
//        Print(arrayOfStrings);
//    }

//    static void Print(string[] toPrint)
//    {
//        for (int i = 0; i < toPrint.Length; i++)
//        {
//            Console.WriteLine(toPrint[i]);
//        }
//    }

//}






