using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_employee_department_
{
    // Department.cs
    public class Department
    {
        // Properties
        public string No { get; set; }
        public Employee[] Employees { get; private set; }
        public int EmployeeLimit { get; set; }

        // Constructor
        public Department(string no, int employeeLimit)
        {
            
            if (no.Length == 2 && char.IsUpper(no[0]) && char.IsUpper(no[1]))
            {
                No = no;
            }
            else
            {
                Console.WriteLine("Department nömrərində 2 böyük hərf olmalıdır");
            }

            
            if (employeeLimit >= 0 && employeeLimit <= 20)
            {
                EmployeeLimit = employeeLimit;
            }
            else
            {
                Console.WriteLine("İşçi limiti 0 ilə 20 arasında olmalıdır");
            }

            Employees = new Employee[0];
        }

        // Methods
        public void AddEmployee(Employee employee)
        {
            // İşçi limitini yoxlayın
            if (Employees.Length < EmployeeLimit)
            {
                Employee[] newArray = new Employee[Employees.Length + 1];
                Array.Copy(Employees, newArray, Employees.Length);
                newArray[Employees.Length] = employee;
                Employees = newArray;
            }
            else
            {
                Console.WriteLine("Employee limit reached. Cannot add more employees.");
            }
        }


        public Employee GetEmployee(string name)
        {
            foreach (var employee in Employees)
            {
                if (employee.Name == name)
                {
                    return employee;
                }
            }

            return null;
        }

        public void GetEmployeeInfo(string name, string surname)
        {
            Employee employee = GetEmployee(name);

            if (employee != null)
            {
                Console.WriteLine($"Name: {employee.Name}, Surname: {employee.Surname}, Age: {employee.Age}, Department No: {employee.DepartmentNo}, Salary: {employee.Salary}");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        public Employee[] GetAllEmployees()
        {
            return Employees;
        }

        public Employee[] GetAllEmployeesBySalary(double minSalary, double maxSalary)
        {
            int count = 0;
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].Salary >= minSalary && Employees[i].Salary <= maxSalary)
                {
                    count++;
                }
            }

            Employee[] result = new Employee[count];
            count = 0;
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].Salary >= minSalary && Employees[i].Salary <= maxSalary)
                {
                    result[count] = Employees[i];
                    count++;
                }
            }

            return result;
        }

        public Employee[] GetAllEmployeesByDepartmentNo(string departmentNo)
        {
            int count = 0;
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].DepartmentNo == departmentNo)
                {
                    count++;
                }
            }

            Employee[] result = new Employee[count];
            count = 0;
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].DepartmentNo == departmentNo)
                {
                    result[count] = Employees[i];
                    count++;
                }
            }

            return result;
        }
    }


}
