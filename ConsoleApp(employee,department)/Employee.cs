using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_employee_department_
{
    // Employee.cs
    public class Employee
    {
        // Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string DepartmentNo { get; set; }

        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set
            {
                // Encapsulation: Salary negative ola bilməz
                if (value >= 0)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("Maaş mənfi ola bilməz.");
                }
            }
        }

        // Constructor
        public Employee(string name, string surname, int age, string departmentNo, double salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            DepartmentNo = departmentNo;
            Salary = salary;
        }
    }

}
