namespace ConsoleApp_employee_department_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program.cs
                Console.WriteLine("Şöbə nömrəsini daxil edin (2 böyük hərf):");
                string departmentNo = Console.ReadLine();

                Console.WriteLine("İşçi limitini daxil edin (0 ilə 20 arasında):");
                int employeeLimit = int.Parse(Console.ReadLine());

                Department department = new Department(departmentNo, employeeLimit);

                int choice;

                do
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Employee əlavə et");
                    Console.WriteLine("2. İşci axtar");
                    Console.WriteLine("3. Bütün işçilərə bax");
                    Console.WriteLine("4. Maaş aralığına görə işçiləri axtarış et");
                    Console.WriteLine("5. Departamentə görə işçiləri axtarış et");
                    Console.WriteLine("0. Proqramı bitir");
                    Console.WriteLine("Seçiminizi daxil edin:");

                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            // Employee əlavə et
                            Console.WriteLine("İşçi məlumatlarını daxil edin:");
                            Console.WriteLine("Ad:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Soyad:");
                            string surname = Console.ReadLine();
                            Console.WriteLine("Yaş:");
                            int age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Maaş:");
                            double salary = double.Parse(Console.ReadLine());

                            Employee employee = new Employee(name, surname, age, departmentNo, salary);
                            department.AddEmployee(employee);
                            break;

                        case 2:
                           //  İşci axtar
                            Console.WriteLine("Ad daxil edin:");
                            string searchName = Console.ReadLine();
                            Console.WriteLine("Soyad daxil edin:");
                            string searchSurname = Console.ReadLine();

                            department.GetEmployeeInfo(searchName, searchSurname);
                            break;

                        case 3:
                            // Bütün işçilərə bax
                            var allEmployees = department.GetAllEmployees();
                            foreach (var emp in allEmployees)
                            {
                                Console.WriteLine($"Ad: {emp.Name}, Soyad: {emp.Surname}, Yaş: {emp.Age}, Department No: {emp.DepartmentNo}, Maaş: {emp.Salary}");
                            }
                            break;

                        case 4:
                            // Maaş aralığına görə işçiləri axtarış et
                            Console.WriteLine("Minimum əmək haqqını daxil edin:");
                            double minSalary = double.Parse(Console.ReadLine());
                            Console.WriteLine("Maksimum əmək haqqını daxil edin:");
                            double maxSalary = double.Parse(Console.ReadLine());

                            var employeesBySalary = department.GetAllEmployeesBySalary(minSalary, maxSalary);
                            foreach (var emp in employeesBySalary)
                            {
                                Console.WriteLine($"Ad: {emp.Name}, Soyad: {emp.Surname}, Yaş: {emp.Age}, Department No: {emp.DepartmentNo}, Maaş: {emp.Salary}");
                            }
                            break;

                        case 5:
                            // Departamentə görə işçiləri axtarış et
                            Console.WriteLine("Şöbə nömrəsini daxil edin:");
                            string searchDepartmentNo = Console.ReadLine();

                            var employeesByDepartmentNo = department.GetAllEmployeesByDepartmentNo(searchDepartmentNo);
                            foreach (var emp in employeesByDepartmentNo)
                            {
                                Console.WriteLine($"Ad: {emp.Name}, Soyad: {emp.Surname}, Yaş: {emp.Age}, Department No: {emp.DepartmentNo}, Maaş: {emp.Salary}");
                            }
                            break;
                    }

                } while (choice != 0);
            
        }

    }
}
