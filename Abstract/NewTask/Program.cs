using System;

namespace NewTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elave olunacaq kitab sayini daxil edin:");
            int size = Convert.ToInt32(Console.ReadLine());
            while (size < 0)
            {
                Console.Clear();
                Console.WriteLine("Elave olunacaq kitab sayini duzgun daxil edin!!!:");
                size = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            Book[] book = new Book[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("KItabin nomresini daxil edin:");
                int No = Convert.ToInt32(Console.ReadLine());
                while (No < 0)
                {
                    Console.Clear();
                    Console.WriteLine("KItabin nomresini duzgun daxil edin!!!:");
                    No = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("KItabin adini daxil edin:");
                string Name = Console.ReadLine();
                while (Name.Trim() == "")
                {
                    Console.Clear();
                    Console.WriteLine("KItabin adini daxil edin!!!:");
                    Name = Console.ReadLine();
                }

                Console.WriteLine("KItabin qiymetini daxil edin:");
                double Price = Convert.ToDouble(Console.ReadLine());
                while (Price < 0)
                {
                    Console.Clear();
                    Console.WriteLine("KItabin qiymetini duzgun daxil edin!!!:");
                    Price = Convert.ToInt32(Console.ReadLine());

                }

                Console.WriteLine("KItabin janrini daxil edin:");
                string Genre = Console.ReadLine();
                while (Genre.Trim() == "")
                {
                    Console.Clear();
                    Console.WriteLine("KItabin janrini daxil edin!!!:");
                    Genre = Console.ReadLine();
                }

                book[i] = new Book(No, Name, Price, Genre);
                Console.Clear();
            }
            Console.WriteLine("[1]-Kitablari qiymete Gore filterle\n");
            Console.WriteLine("[2]-Butun Kitablari goster\n");
            Console.WriteLine("[3]-Programi Bagla");

            int select = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (select == 1)
            {
                int count = 0;
                Console.WriteLine("Kitablar Filtri:\n\n");
                Console.WriteLine("Minimum ve Maximum deyerleri daxil edin:\n");
                Console.WriteLine("\nMin:");
                int min = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nMax:");
                int max = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                foreach (var item in book)
                {
                    if (item.Price >= min && item.Price <= max)
                    {
                        count++;
                        Console.WriteLine($"KItabin nomresi: {item.No}\nKitabin adi: {item.Name}\nKitabin qiymeti: {item.Price}\n");
                        Console.WriteLine($"bu qiymet araliginda {item.Count} kitabdan {count} sayda kitab var");
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("\n\n      bu qiymet araliginda kitab movcud deyil!!");
                }
            }
            else if (select == 2)
            {
                
                foreach (var item in book)
                {
                    Console.WriteLine($"Butun kitablar:\nKitablarin sayi: {item.Count}\n\n");
                    Console.WriteLine($"KItabin nomresi: {item.No}\nKitabin adi: {item.Name}\n");
                }
            }
            else if (select == 3)
            {
                Environment.Exit(0);
            }
        }
    }
}
