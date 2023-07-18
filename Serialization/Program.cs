using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;
using Serialization.Task1;
using Serialization.Task2;
using Serialization.Task3;

Task1();
Task2();
Task3();

void Task1()
{
    Employee employee = new() { EmployeeName = "John Doe" };
    Department department = new() { DepartmentName = "IT" };
    department.Employees.Add(employee);

    Console.WriteLine("Binary Serialization:");
    BinarySerialization.PerformSerialization(department);
    BinarySerialization.PerformDeserialization();

    Console.WriteLine();

    Console.WriteLine("XML Serialization:");
    XMLSerialization.PerformSerialization(department);
    XMLSerialization.PerformDeserialization();

    Console.WriteLine();

    Console.WriteLine("JSON Serialization:");
    JSONSerialization.PerformSerialization(department);
    JSONSerialization.PerformDeserialization();

    Console.WriteLine();
}

void Task2()
{
    Console.WriteLine("Custom Serialization:");
    CustomSerializationMechanism.PerformSerialization();
    CustomSerializationMechanism.PerformDeserialization();
}

void Task3()
{
    Console.WriteLine("Deep Cloning:");
    DeepCloning.PerformDeepCloning();
}
