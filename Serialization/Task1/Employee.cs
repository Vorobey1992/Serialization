using ProtoBuf;
using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Serialization.Task1
{
    [ProtoContract]
    public class Employee
    {
        [ProtoMember(1)]
        [XmlElement("Name")]
        [JsonPropertyName("name")]
        public string? EmployeeName { get; set; }
    }
}
