using System;
using System.Xml.Serialization;

namespace WIMSystemService.XmlElement
{
    //[XmlRoot("DOC")]
    public class CommunicationInfor
    {
        [XmlAttribute("type")]
        public string Type { get; set; }
        [XmlAttribute("version")]
        public string Version { get; set; }
        [XmlAttribute("number")]
        public string Number { get; set; }
        [XmlAttribute("send_time")]
        public string SendTime { get; set; }
        [XmlAttribute("transmission")]
        public string Transmission { get; set; }
    }
}
