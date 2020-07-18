using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using YamlDotNet.Serialization;

namespace MonitoringAndTesting
{
    public static class Extensions
    {
        public static void Output(this object item)
        {
            var serializer = new SerializerBuilder().Build();
            var yaml = serializer.Serialize(item);
            Console.WriteLine(yaml);
        }
    }
}
