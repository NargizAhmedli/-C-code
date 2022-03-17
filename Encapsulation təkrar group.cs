using System;
using System.Collections.Generic;
using System.Text;

namespace Group_class
{
    class Group
    {
        private string _no;
        private int _studentlimit;

        public int Studentlimit
        {
            get => this._studentlimit;
            set
            {
                if (value >= 0)
                {
                    this._studentlimit = value;
                }
            }
        }
        public string No
        {
            get => this._no;
            set
            {
                if (value.Length > 0 && Num(value)) 
                {
                    this._no = value;
                }
            }
        }
        public bool Num(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                if (char.IsUpper(str[0]) && char.IsUpper(str[1]))
                    return true;
                if (char.IsDigit(str[2]) && char.IsDigit(str[3]) && char.IsDigit(str[4]))
                    return true;


            }
                return false;
        }
       

        }
    }
