using System;
using System.IO;
using ProtoBuf;

namespace Serialization.Task1
{
    class BinarySerialization
    {
        public static void PerformSerialization(Department department)
        {
            using FileStream stream = new("department.bin", FileMode.Create);
            Serializer.Serialize(stream, department);
        }

        public static void PerformDeserialization()
        {
            using FileStream stream = new("department.bin", FileMode.Open);
            Department deserializedDepartment = Serializer.Deserialize<Department>(stream);
            Console.WriteLine("Department Name: " + deserializedDepartment.DepartmentName);
            foreach (Employee employee in deserializedDepartment.Employees)
            {
                Console.WriteLine("Employee Name: " + employee.EmployeeName);
            }
        }
    }
}
