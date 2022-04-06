using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("[1]--Send Message via Email\n");
                Console.WriteLine("[2]--Send Message via Sms\n");
                Console.WriteLine("[0]--Exit Application\n");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (number)
                {
                    case 1:
                        EmailSender email = new EmailSender();
                        email.SendMessage();
                        break;
                    case 2:
                        SmsSender sms = new SmsSender();
                        sms.SendMessage();
                        break;
                    case 0:
                        Console.WriteLine("Application Closed!");
                        Environment.Exit(0);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Bu deyere uygun gelen secim yoxdur");

                }

            }
        }
    }
}
