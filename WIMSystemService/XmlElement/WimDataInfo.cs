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
        public bool Direction { get; set; }
        [XmlAttribute("head")]
        public int Head { get; set; }
        [XmlAttribute("gap")]
        public int Gap { get; set; }
        [XmlAttribute("speed")]
        public int VehicleSpeed { get; set; }
         [XmlAttribute("width")]
        public int Width { get; set; }
         [XmlAttribute("height")]
        public int Height { get; set; }
        [XmlAttribute("length")]
        public int VehicleLength { get; set; }
        [XmlAttribute("class")]
        public int VehicleClass { get; set; }
        [XmlAttribute("overloaded_total")]
        public int IsOverload { get; set; }
        [XmlAttribute("weight_total ")]
        public int GrossWeigth { get; set; }
        [XmlAttribute("credibility")]
        public string Credibility { get; set; }

        [XmlArray("AXLES")]
        [XmlArrayItem("AXLE")]
        public AxleDataInfor AxleDataInfor { get; set; }
    }
}
