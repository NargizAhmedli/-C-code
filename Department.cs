using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    internal class Department
    {
        public string Name;
        private int _employeeLimit;
        private int _salaryLimit;
        public Employee[] Employees = new Employee[0];
        public int EmployeeLimit
        {
            get
            {
                return _employeeLimit;
            }
            set
            {
                if (value >= 2 && value <= 4)
                    _employeeLimit = value;
            }
        }
        public int SalaryLimit
        {
            get
            {
                return _salaryLimit;
            }
            set
            {
                if (value == 250)
                    _salaryLimit = value;
            }
        }
        public void AddEmployee(Employee employee)
        {

            if (Employees.Length == EmployeeLimit)
                throw new Exception("Limit doldu");
         
        }
    }
}
