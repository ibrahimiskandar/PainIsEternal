using System;
using System.Collections.Generic;
using System.Text;

namespace _04april
{
    interface IAccount
    {
        bool PasswordChecker(string password);
        void ShowInfo();
    }
}
