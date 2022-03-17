using System;

namespace csharptask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Binary(7);
            
        }

        static void Binary(int a)
        {
            int binary = 0;
            int digit = 0;
            while (a > 0)
            {
                digit = a % 2;
                a /= 2;
                binary += digit;
            }
                
            Console.WriteLine(binary);
        }

    }

}
