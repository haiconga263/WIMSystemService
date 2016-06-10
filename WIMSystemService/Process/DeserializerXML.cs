using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WIMSystemService.Deserializer
{
    public class DeserializerXML<T>
        where T : class, new()
    {
        public static T Deserializer(string Name)
        {
            using (TextReader reader = new StreamReader(Name))
            {
                try
                {
                    var xmlSerializer = new XmlSerializer(typeof(T));
                    T data = xmlSerializer.Deserialize(reader) as T;
                    return data;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}