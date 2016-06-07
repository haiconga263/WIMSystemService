using System.Xml.Serialization;

namespace WIMSystemService.XmlElement
{
    public class AxleDataInfor
    {
        [XmlAttribute("order")]
        public int Order { get; set; }
        [XmlAttribute("dist")]
        public int Distance { get; set; }
        [XmlAttribute("weight")]
        public float AxleWeight { get; set; }
        [XmlAttribute("leftside_load")]
        public float LeftsideLoad { get; set; }
        [XmlAttribute("rightside_load")]
        public float RightsideLoad { get; set; }
        [XmlAttribute("overloaded")]
        public float Overloaded { get; set; }
        [XmlAttribute("tires_count")]
        public int TiresCount { get; set; }
    }
}
