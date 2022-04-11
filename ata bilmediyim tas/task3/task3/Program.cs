using System;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Pizza Mozzarella Rera Rera Rera";

            RvrsText(text);
        }
        static void RvrsText(string text)
        {
            StringBuilder newtext;
            int lastspace = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    lastspace = i;
                }

            }
            for (int j = lastspace+1; j < text.Length; j++)
            {
                newtext.Append(text[j]);
            }
            Console.WriteLine(text);
        }
    }
}



