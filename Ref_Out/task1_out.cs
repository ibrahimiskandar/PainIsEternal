using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            int variable = 345;
            AddEl(out arr, variable);
        }
        static void AddEl(out int[] arr, int variable)
        {
            int[] array = { 98, 12, 65, 45, 90, 34, 77 };
            int[] newarr = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newarr[i] = array[i];
            }
            newarr[array.Length] = variable;
            arr = newarr;
            foreach (var item in newarr)
            {
                Console.WriteLine(item);
            }
        }
    }
}