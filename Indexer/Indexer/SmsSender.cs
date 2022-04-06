using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer
{
    class SmsSender:MessagSender
    {
        public override  void SendMessage()
        {
            Console.WriteLine("Mesajinizi daxil edin:");
            string message = Console.ReadLine();
            Console.WriteLine($"{message} 0502343454 nomresine Gonderildi!");


        }
    }
}
