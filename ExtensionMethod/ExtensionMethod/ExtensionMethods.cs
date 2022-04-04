using System;
using System.Collections.Generic;
using System.Text;

namespace UpDowncasting
{
    static class ExtensionMethods
    {
        public static bool CustomContains(this string word, char contains)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == contains)
                {
                    Console.WriteLine(true);
                    return true;
                }
            }
            Console.WriteLine(false);
            return false;
        }
        public static bool CustomContains(this string word, string contains)
        {
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == contains[0])
                {
                    for (int j = 1; j < contains.Length && i + j < word.Length; j++)
                    {
                        if (word[j + i] == contains[j])
                        {
                            count++;
                        }
                        if (count == contains.Length - 1)
                        {
                            Console.WriteLine(true);
                            return true;
                        }
                    }
                }
                count = 0;
            }
            Console.WriteLine(false);
            return false;
        }
        public static bool IsPrime(this int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count <3)
            {
                Console.WriteLine(true);
                return true;
            }
            Console.WriteLine(false);
            return false;
        }
    }
}