using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Serialization.Task1
{
    [ProtoContract]
    public class Department
    {
        private string departmentName;

        [ProtoMember(1)]
        [XmlAttribute]
        [JsonPropertyName("departmentName")]
        public string DepartmentName
        {
            get { return departmentName ?? string.Empty; }
            set { departmentName = value; }
        }

        [ProtoMember(2)]
        [XmlArray("Employees")]
        [XmlArrayItem("Employee")]
        [JsonPropertyName("employees")]
        public List<Employee> Employees { get; set; }

        public Department()
        {
            departmentName = string.Empty;
            Employees = new List<Employee>();
        }
    }
}
