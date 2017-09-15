using System;


namespace _12.Parse_URL
{
    class Program
    {
        static void Main()
        {
            string inputURL = Console.ReadLine();


            int firstIndex = inputURL.IndexOf("//");
            int secondIndex = inputURL.IndexOf("/", firstIndex + 2);
            string protocol = inputURL.Substring(0, inputURL.IndexOf(":"));
            string server = inputURL.Substring(firstIndex + 2, secondIndex - (firstIndex + 2));
            string resource = inputURL.Substring(secondIndex);
            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
            
        }
    }
}
