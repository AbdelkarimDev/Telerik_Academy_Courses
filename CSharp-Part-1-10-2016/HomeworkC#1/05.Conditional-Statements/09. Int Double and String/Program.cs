using System;


namespace _09.Int_Double_and_String
{
    class Program
    {
        static void Main()
        {
            string descripton = Console.ReadLine();
            switch (descripton)
            {
                case "integer":
                    {
                        int integer = int.Parse(Console.ReadLine());
                        Console.WriteLine(integer + 1);
                    }
                    break;
                case "real":
                    {
                        double real = double.Parse(Console.ReadLine());
                        Console.WriteLine("{0:F2}",( real + 1));
                    }
                    break;
                case "text":
                    {
                        string text = Console.ReadLine();
                        Console.WriteLine(text + "*");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
