using System;
using System.IO;
using System.Xml.Serialization;

namespace Serialization.Task1
{
    class XMLSerialization
    {
        public static void PerformSerialization(Department department)
        {
            XmlSerializer serializer = new(typeof(Department));
            using StreamWriter writer = new("department.xml");
            serializer.Serialize(writer, department);
        }

        public static void PerformDeserialization()
        {
            XmlSerializer serializer = new(typeof(Department));
            using StreamReader reader = new("department.xml");
            Department? deserializedDepartment = (Department?)serializer.Deserialize(reader);
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
