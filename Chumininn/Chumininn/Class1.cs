using System;
using System.Collections.Generic;
using System.Text;

namespace _04april
{
    class User : IAccount
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; }
   
        public bool PasswordChecker(string password)
        {
            bool isUpper=false;
            bool isLower=false;
            bool isNumber=false;

            if (password.Length >= 8)
            {
                foreach (var item in password)
                {
                    if (char.IsUpper((item)))
                    {
                        isUpper = true;
                    }
                    if (char.IsLower((item)))
                    {
                        isLower = true;
                    }
                    if (char.IsNumber((item)))
                    {
                        isNumber = true;
                    }
                }
                if (isUpper==true && isLower==true && isNumber==true)
                {
                    Console.WriteLine("sifrenin formati duzgun yazilmisdir");
                    return true;
                }
                else
                {

                    Console.WriteLine("sifrenin formati duzgun deyil");
                   
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Sifre en az 8 simvol olmaldir");
                return false;
            }

        }
        public void ShowInfo()
        {
            Console.WriteLine($"Fullname : {Fullname} Email : {Email}"); ;
        }
    }
}
