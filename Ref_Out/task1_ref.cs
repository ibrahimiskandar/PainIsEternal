using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr =  { 98, 12, 65, 45, 90, 34, 77 };
            int variable = 420;
            addEl(ref arr, variable);
        }
        static void addEl(ref int[] arr, int variable)
        {
            int[] newarr = new int [arr.Length+1];
            for (int i = 0; i < arr.Length; i++)
            {
                newarr[i] = arr[i];
            }
            newarr[arr.Length] = variable;
            arr = newarr;
            foreach (var item in newarr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
