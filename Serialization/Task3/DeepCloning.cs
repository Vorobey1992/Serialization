using Serialization.Task1;
using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Serialization.Task3
{
    class DeepCloning
    {
        public static void PerformDeepCloning()
        {
            Department department = new()
            {
                DepartmentName = "IT",
                Employees = new List<Employee>
                {
                    new Employee { EmployeeName = "John Doe" },
                    new Employee { EmployeeName = "Jane Smith" }
                }
            };

            Department clonedDepartment = DeepClone(department);

            // Modify the clonedDepartment and original department
            clonedDepartment.DepartmentName = "HR";
            clonedDepartment.Employees[0].EmployeeName = "Mark Johnson";

            Console.WriteLine("Cloned Department:");
            Console.WriteLine("Department Name: " + clonedDepartment.DepartmentName);
            foreach (Employee employee in clonedDepartment.Employees)
            {
                Console.WriteLine("Employee Name: " + employee.EmployeeName);
            }

            Console.WriteLine();

            Console.WriteLine("Original Department:");
            Console.WriteLine("Department Name: " + department.DepartmentName);
            foreach (Employee employee in department.Employees)
            {
                Console.WriteLine("Employee Name: " + employee.EmployeeName);
            }
        }

        static T DeepClone<T>(T obj)
        {
            using var memoryStream = new MemoryStream();
            Serializer.Serialize(memoryStream, obj);
            memoryStream.Seek(0, SeekOrigin.Begin);
            return Serializer.Deserialize<T>(memoryStream);
        }
    }
}
