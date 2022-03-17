using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    internal class User
    {
        private string _username;
        private string _password;

        public string Username
        {
            get => _username;
            set
            {
                if (value.Length > 5 && value.Length < 25)
                    this._username = value;
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                if (value.Length >= 8 && value.Length <= 25)
                    this._password = value;
            }
        }
        static bool Checkinpassword(string _password)
        {
            bool countupper = false;
            bool countlower = false;
            bool countdigit = false;

            for (int i = 0; i < _password.Length; i++)
            {
                if (char.IsUpper(_password[i]))
                {
                    countupper = true;
                }
                else if (char.IsLower(_password[i]))
                {
                    countlower = true;
                }
                else if (char.IsDigit(_password[i]))
                {
                    countdigit = true;
                }
                if (countdigit && countlower && countupper)
                {
                    return true;
                }
            }
            return false;

        }
        static bool HasDigit(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    return true;
                }
            }
            return false;
            
        }
        static bool HasUpper(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]))
                {
                    return true;
                }
            }
            return false;

        }
        static bool HasLower(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLower(word[i]))
                {
                    return true;
                }
            }
            return false;

        }
    }
}
