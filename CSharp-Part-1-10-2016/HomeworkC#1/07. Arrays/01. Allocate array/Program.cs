﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Allocate_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] Array = new int[N];

            for (int i = 0; i < Array.Length; i++)
            {
 
             Array[i] = i*5;
                Console.WriteLine("{0}", Array[i]);
            }
        }

    }
}
