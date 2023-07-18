using System;
using System.IO;
using System.Text.Json;

namespace Serialization.Task1
{
    class JSONSerialization
    {
        public static void PerformSerialization(Department department)
        {
            string jsonString = JsonSerializer.Serialize(department);
            if (jsonString != null)
            {
                using StreamWriter writer = new("department.json");
                writer.Write(jsonString);
            }
        }

        public static void PerformDeserialization()
        {
            using StreamReader reader = new("department.json");
            string? jsonContent = reader.ReadToEnd();
            Department? deserializedDepartment = JsonSerializer.Deserialize<Department>(jsonContent);
            if (deserializedDepartment != null)
            {
                Console.WriteLine("Department Name: " + deserializedDepartment.DepartmentName);
                foreach (Employee employee in deserializedDepartment.Employees)
                {
                    Console.WriteLine("Employee Name: " + employee.EmployeeName);
                }
            }
        }
    }
}
