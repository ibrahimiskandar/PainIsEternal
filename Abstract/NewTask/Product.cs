using System;
using System.Collections.Generic;
using System.Text;

namespace NewTask
{
    class Product
    {
        public int No { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; }
        private static int CountIncreaser;

        public Product()
        {
            CountIncreaser++;
            Count=CountIncreaser;
        }

        public Product(int no, string name, double price)
        {
            No = no;
            Name = name;
            Price = price;
        }
    }
}
