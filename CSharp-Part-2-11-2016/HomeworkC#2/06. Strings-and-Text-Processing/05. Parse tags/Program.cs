using System;


class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        var upper = text.Split(new[] { "</upcase>", "<upcase>" }, StringSplitOptions.None);

        for (int i = 1; i < upper.Length; i += 2)
        {

            upper[i] = upper[i].ToUpper();

        }
        Console.WriteLine(string.Join("", upper));



    }
}





//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _05.Parse_tags
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            string text = Console.ReadLine();
//            int start = text.IndexOf("<upcase>");
//            int end = text.IndexOf("</upcase>");
//            StringBuilder buffer = new StringBuilder();

//            while (start != -1)
//            {
//                for (int i = start + 8; i < end; i++)
//                {

//                    buffer.Append(text[i]);

//                }
//                //text = text.Remove(start, end - start + 9);
//                text = text.Replace("<upcase>"+buffer.ToString()+"</upcase>", buffer.ToString().ToUpper());
//                buffer.Clear();
//                start = text.IndexOf("<upcase>", start + 1);
//                if (start == -1)
//                {
//                    break;
//                }
//                end = text.IndexOf("</upcase>", end + 1);




//            }
//            Console.WriteLine(text);
//        }
//    }
//}
