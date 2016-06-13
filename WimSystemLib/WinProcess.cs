using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WimSystemLib
{
    public class MySerializerXML<T>where T : class, new()
    {

        public static void Serialize_Request_Config(T source, string Name)
        {
            if (source == null)
                throw new ArgumentNullException("source", "Object to serialize cannot be null");
            using (TextWriter writer = new StreamWriter(string.Format(Name + ".xml")))
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(writer, source);
            }
        }
        public static void Serialize_Request_Data(T source, string Name)
        {
            if (source == null)
                throw new ArgumentNullException("source", "Object to serialize cannot be null");
            using (TextWriter writer = new StreamWriter(string.Format(Name + ".xml")))
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(writer, source);
            }
        }
        public static void Serialize_Request_Resend_Data(T source, string Name)
        {
            if (source == null)
                throw new ArgumentNullException("source", "Object to serialize cannot be null");
            using (TextWriter writer = new StreamWriter(string.Format(Name + ".xml")))
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(writer, source);
            }
        }
    }
    public class MyDeserializerXML<T> where T : class, new()
    {
        public static T Deserialize_Alarm_OverSpeed(string xmlName)
        {
            using (TextReader reader = new StreamReader(xmlName))
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
        public static T Deserialize_Alarm_OverWeight(string xmlName)
        {
            using (TextReader reader = new StreamReader(xmlName))
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

        public static T Deserialize_DataAggregation(string xmlName)
        {
            using (TextReader reader = new StreamReader(xmlName))
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

        public static T Deserialize_DataAggregationType(string xmlName)
        {
            using (TextReader reader = new StreamReader(xmlName))
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

        public static T Deserialize_Config(string xmlName)
        {
            using (TextReader reader = new StreamReader(xmlName))
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