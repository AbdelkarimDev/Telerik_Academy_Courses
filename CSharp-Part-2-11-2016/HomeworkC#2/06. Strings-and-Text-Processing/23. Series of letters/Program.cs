namespace CompressString
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            // compress a string by replacing a sequences of repeating characters with the character followed by the count of the repetitions
            var text = Console.ReadLine();

            var compressed = new StringBuilder();

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i - 1] != text[i])
                {
                    compressed.Append(text[i - 1]);
                }
              
            }

            compressed.Append(text[text.Length - 1]);

            Console.WriteLine(compressed);
        }
    }
}