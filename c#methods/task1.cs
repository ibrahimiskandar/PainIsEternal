using System;

namespace csharptask1
{
    class Program
    {
        static void Main(string[] args)
        {
           largest(1, 3, 4, 5, 6) ;

        }

        static void largest(params int[] arr)
        {

            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];


            Console.WriteLine(max);
        }

    }

}