using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine(nearestRoot(out num));
        }
        static int nearestRoot(out int num)
        {
            int number = 257;
            int root = 0;
            while (root * root <= number)
            {
                root++;
            }
            num = root - 1;
            return num;
        }
    }
}