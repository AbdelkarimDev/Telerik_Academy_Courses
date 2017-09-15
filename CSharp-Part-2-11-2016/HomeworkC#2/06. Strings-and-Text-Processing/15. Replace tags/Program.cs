using System;

class ReplaceTagsV3
{

    //<p>Please visit<a href= "http://academy.telerik.com" > our site</a>
    //to choose a training course. Also visit <a href = "www.devbg.org" > our forum</a> to discuss the courses.</p>

    static void Main()
    {
        string inputText = Console.ReadLine();
        string[] separators = { "<a href=\"", "</a>" };
        string[] splitedText = inputText.Split(separators, StringSplitOptions.None);
        for (int i = 1; i < splitedText.Length; i += 2)
        {
            int index = splitedText[i].IndexOf("\">");
            string url = splitedText[i].Substring(0, index);
            string linkText = splitedText[i].Substring(index + 2, splitedText[i].Length - index - 2);
            splitedText[i] = "[" + linkText + "]" + "(" + url + ")";
        }
        Console.WriteLine(string.Join(string.Empty, splitedText));
    }
}