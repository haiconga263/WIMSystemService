using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace WIMSystemService.XmlElement
{
    public class WimDataInfo
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
         [XmlAttribute("direction")]
        public string Direction { get; set; }
        [XmlAttribute("head")]
        public string Head { get; set; }
        [XmlAttribute("gap")]
        public string Gap { get; set; }
        [XmlAttribute("speed")]
        public string VehicleSpeed { get; set; }
         [XmlAttribute("width")]
        public string Width { get; set; }
         [XmlAttribute("height")]
        public string Height { get; set; }
        [XmlAttribute("length")]
        public string VehicleLength { get; set; }
        [XmlAttribute("class")]
        public string VehicleClass { get; set; }
        [XmlAttribute("overloaded_total")]
        public string IsOverload { get; set; }
        [XmlAttribute("weight_total ")]
        public string GrossWeigth { get; set; }
        [XmlAttribute("credibility")]
        public string Credibility { get; set; }

        [XmlElement("AXLES")]
        public AxlesInfor AxleDataInfor { get; set; }
       

    }
}
