using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer
{
    class EmailSender:MessagSender
    {
        public override  void SendMessage()
        {
            Console.WriteLine("Mesajinizi daxil edin:");
            string message = Console.ReadLine();
            Console.WriteLine($"{message} 7nxjjfg@code.edu.az emailine  Gonderildi!");
        }
    }
}
