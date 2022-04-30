using System;
using System.Collections.Generic;
using System.Text;

namespace Tehsil_Sistemi
{
    internal interface IAccount
    {
        public bool PasswordChecker(string pw);
        public void ShowInfo();

    }
}
