using System;


namespace _13.ModifyBit
{
    class Program
    {

        static void Main(string[] args)
        {
            ulong N = ulong.Parse(Console.ReadLine());  //inputs the number N
            int P = int.Parse(Console.ReadLine());  //inputs P position
            uint v = uint.Parse(Console.ReadLine());  //inputs v new bit value
            Console.WriteLine("{0}", ((N & (~(1UL << P))) | ((ulong)v << P)));
        }
    }
}


//ulong number = ulong.parse(console.readline());
//int posision = int.parse(console.readline());
//byte value = byte.parse(console.readline());
//ulong newnumber = 0;
//    if (value == 0)
//    {
//        ulong mask = (ulong)(~(1 << posision));
//newnumber = number & (mask);
//        console.writeline(newnumber);
//    }

//    else
//    {
//        ulong mask1 = (ulong)(1 << posision);
//newnumber = number | (mask1);
//        console.writeline(newnumber);
//}
//        }
//    }
//}


