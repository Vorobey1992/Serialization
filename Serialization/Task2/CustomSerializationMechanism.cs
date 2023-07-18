using System;
using System.IO;
using ProtoBuf;

namespace Serialization.Task2
{
    class CustomSerializationMechanism
    {
        public static void PerformSerialization()
        {
            MyClass original = new() { Property1 = "Value 1", Property2 = 42 };

            using FileStream stream = new("serialized.bin", FileMode.Create);
            Serializer.Serialize(stream, original);
        }

        public static void PerformDeserialization()
        {
            MyClass deserialized;
            using (FileStream stream = new("serialized.bin", FileMode.Open))
            {
                deserialized = Serializer.Deserialize<MyClass>(stream);
            }

            Console.WriteLine("Custom Deserialization - Property1: " + deserialized.Property1);
            Console.WriteLine("Custom Deserialization - Property2: " + deserialized.Property2);
        }
    }

    [ProtoContract]
    class MyClass
    {
        [ProtoMember(1)]
        public string Property1 { get; set; } = string.Empty;

        [ProtoMember(2)]
        public int Property2 { get; set; }
    }
}
