using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    internal class Employee
    {

        private string _name;
        private string _surName;
        private int _salary;
        public string EmployeeName
        {
            get
            {
                return _name;
            }
            set
            {
                if (Checker(value))
                    _name = value;
            }
        }
        public string Surname
        {
            get
            {
                return _surName;
            }
            set
            {
                if (Checker(value))
                    _surName = value;
            }
        }
        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value >= 250)
                    _salary = value;
            }
        }
        public string GetInfo()
        {
            return $"Ad: {this._name} Soyad: {this._surName} Maas: {this._salary} ";
        }
        public bool Checker(string value)
        {
            int count = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsLetter(value[i]))
                    count++;
            }
            if (count == value.Length && char.IsUpper(value[0]) && !string.IsNullOrWhiteSpace(value))
                return true;
            return false;
        }
    }
}
