using System.Xml.Serialization;

namespace WIMSystemService.XmlElement
{
    public class DeviceTypeInfor
    {
        [XmlAttribute("receiver")]
        public string Receiver { get; set; }
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlAttribute("desc")]
        public string Description { get; set; }
        [XmlAttribute("actual_time")]
        public string ConfigTime { get; set; }
    }

    public class ConfigDevice
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlAttribute("desc")]
        public string Description { get; set; }
    }
}
