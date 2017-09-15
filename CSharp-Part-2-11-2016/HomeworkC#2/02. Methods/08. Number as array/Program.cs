//Write a method that adds two positive integer numbers represented as arrays of digits
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits

using System;
using System.Linq;


class SumNumbersAsArrays
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

      
        int[] firstNumber = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondNumber = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

     

        int[] result = SumNumbers(firstNumber, secondNumber);

       // Result:
        for (int i = 0; i < result.Length - 1; i++)
        {
            if ((result[i] == 0) && i == result.Length - 1)
            {
                continue; //Skip the first digit if it is zero
            }

           Console.Write("{0} ",result[i]);
            
      
          //  Console.WriteLine(string.Join(" ", result).TrimEnd('0', ' '));-moje da se zapishe celiat resultat i taka
        }
       
    }

    static byte[] ConvertToArray(string strNumber)
    {
        byte[] arrayNumber = new byte[strNumber.Length];

        for (int i = 0; i < arrayNumber.Length; i++)
        {
            arrayNumber[i] = (byte)Char.GetNumericValue(strNumber[arrayNumber.Length - (i + 1)]);
        }
        return arrayNumber;
    }

    static int[] SumNumbers(int[] number1, int[] number2)
    {
        int length = 0;
        int add = 0;
        if (number1.Length >= number2.Length) // Set the length of result array
        {
            length = number1.Length + 1;
        }
        else
        {
            length = number2.Length + 1;
        }

        int[] result = new int[length];
        number1 = AddingZeros(number1, length);
        number2 = AddingZeros(number2, length);

        for (int i = 0; i < result.Length; i++)
        {
            if (add == 0)
            {
                if (number1[i] + number2[i] <= 9)
                {
                    result[i] = (byte)(number1[i] + number2[i]);
                    continue;
                }
                if (number1[i] + number2[i] > 9)
                {
                    result[i] = (byte)(number1[i] + number2[i] - 10);
                    add = 1;
                    continue;
                }
            }

            if (add == 1)
            {
                if (number1[i] + number2[i] + add <= 9)
                {
                    result[i] = (byte)(number1[i] + number2[i] + add);
                    add = 0;
                    continue;
                }
                if (number1[i] + number2[i] + add > 9)
                {
                    result[i] = (byte)(number1[i] + number2[i] + add - 10);
                    add = 1;
                    continue;
                }
            }

        }

        return result;
    }

    static int[] AddingZeros(int[] inputArray, int length) // Extend the length of the arrays to make adding possible 
    {
        int[] extendArray = new int[length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            extendArray[i] = inputArray[i];
        }
        return extendArray;
    }
}

