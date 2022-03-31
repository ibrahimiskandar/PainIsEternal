using System;
using System.Collections.Generic;
using System.Text;

namespace NewTask
{
    class Book : Product
    {
        public string Genre { get; set; }

        public Book(int no, string name, double price, string genre) : base(no, name, price)
        {

            Genre = genre;

        }
    }
}