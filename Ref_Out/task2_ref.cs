using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Made in Heaven";
            RmvSpace(ref text);
        }
        static void RmvSpace(ref string text)
        {
            string newtext = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    continue;
                }
                newtext += text[i];
            }
            text = newtext;
            Console.WriteLine(text);
        }
    }
}