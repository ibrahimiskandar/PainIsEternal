using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 257;
            Console.WriteLine(NearestRoot(ref num));
        }
        static int NearestRoot(ref int num)
        {
            int root = 0;
            while (root * root <= num)
            {
                root++;
            }
            num = root-1;
            return num;
        }
    }
}