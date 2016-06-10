using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WIMSystemService.Serializer
{
    public class MySerializerXML<T>
        where T: class, new() 
    {
    
        public static void Serialize(T source, string Name)
        {
            if (source == null)
                throw new ArgumentNullException("source", "Object to serialize cannot be null");
            using (TextWriter writer = new StreamWriter(string.Format(Name+".xml")))
                {
                    var xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(writer, source);
                }   
        }
    }
}
