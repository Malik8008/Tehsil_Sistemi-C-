using System;
using System.Collections.Generic;
using System.Text;

namespace Tehsil_Sistemi
{
    internal class User : IAccount
    {
        private int _id;
        public static int ID = 0;
        public string Fullname { get; set; }
        public string Email { get; set; }
        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.Length>8)
                {
                    PasswordChecker(value);
                    _password=value;
                }
            }
        }


        public User(string fullname,string email,string password)
        {
            ID = ++_id;
            Fullname = fullname;
            Email = email;
        }

        public bool PasswordChecker(string pw)
        {
            bool HasDigit = false;
            bool HasUpper = false;
            bool HasLower = false;

            foreach (var item in pw)
            {               
                if (char.IsDigit(item))
                {
                    HasDigit = true;
                }
                if (char.IsUpper(item))
                {
                    HasUpper = true;
                }
                if (char.IsLower(item))
                {
                    HasLower = true;
                }
            }
            bool result = HasDigit && HasUpper && HasLower;
            return result;

        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID:{ID}  ||  Fullname:{Fullname}  ||  Email:{Email}");
        }
    }
}
