using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class User
    {
        private string _username;
        private string _password;
        public string username 
        {
            get
            {
                return _username;
            }
            set
            {
                if(value.Length>=6 && value.Length<=25)
                {
                    _username = value;
                }
            } 
        }
        public string password 
        {
            get
            {
                return _password;
            }
            set
            {
                if(value.Length>=8 && value.Length<=25)
                {
                    if (HasDigit(value) && HasLower(value) && HasUpper(value))
                    {
                        _password = value;
                    }
                }
            }
        }

        public bool HasDigit(string value)
        {
            bool result = false;
            foreach (char c in value)
            {
                if (char.IsDigit(c))
                {
                    result = true;
                }
            }
            return result;
        }

        public bool HasUpper(string value)
        {
            bool result = false;
            foreach (char c in value)
            {
                if (char.IsUpper(c))
                {
                    result = true;
                }
            }
            return result;
        }
        public bool HasLower(string value)
        {
            bool result = false;
            foreach (char c in value)
            {
                if (char.IsLower(c))
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
