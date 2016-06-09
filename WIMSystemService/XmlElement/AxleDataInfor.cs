using System.Collections.Generic;
using System.Xml.Serialization;

namespace WIMSystemService.XmlElement
{
    [XmlRoot("AXLES")]
    public class AxlesInfor
    {
        [XmlAttribute("count")]
        public string Count { get; set; }
        [XmlAttribute("length")]
        public string Length { get; set; }

        [XmlElement("AXLE")]
        //[XmlArrayItem("AXLE", typeof(AxleDataInfor))]
        public List<AxleDataInfor> ListAxles { get; set; }
    }
    public class AxleDataInfor 
    {
        [XmlAttribute("order")]
        public string Order { get; set; }
        [XmlAttribute("dist")]
        public string Distance { get; set; }
        [XmlAttribute("weight")]
        public string AxleWeight { get; set; }
        [XmlAttribute("leftside_load")]
        public string LeftsideLoad { get; set; }
        [XmlAttribute("rightside_load")]
        public string RightsideLoad { get; set; }
        [XmlAttribute("overloaded")]
        public string Overloaded { get; set; }
        [XmlAttribute("tires_count")]
        public string TiresCount { get; set; }
    }
}
