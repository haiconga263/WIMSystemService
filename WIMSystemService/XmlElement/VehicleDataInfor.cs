using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace WIMSystemService.XmlElement
{
    public class VehicleDataInfor
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlAttribute("time")]
        public string DectectionTime { get; set; }
        [XmlAttribute("lp_front")]
        public string PlateNumberFront { get; set; }
        [XmlAttribute("lp_front_ilpc")]
        public string PlateNumberCountryCodeFront { get; set; }
        [XmlAttribute("lp_back")]
        public string PlateNumberBack { get; set; }
        [XmlAttribute("lp_back_ilpc")]
        public string PlateNumberCountryCodeBack { get; set; }
        [XmlAttribute("direction")]
        public string Direction { get; set; }
        [XmlAttribute("head")]
        public string Head { get; set; }
        [XmlAttribute("gap")]
        public string Gap { get; set; }
        [XmlAttribute("speed")]
        public string VehicleSpeed { get; set; }
        [XmlAttribute("length")]
        public string VehicleLength { get; set; }
        [XmlAttribute("class")]
        public string  VehicleClass { get; set; }
        [XmlAttribute("overloaded_total")]
        public string IsOverload { get; set; }
        [XmlAttribute("weight_total ")]
        public string GrossWeigth { get; set; }
        [XmlAttribute("credibility")]
        public string Credibility { get; set; }
        [XmlElement("LP_IMAGE_FRONT")]
        public string PlateNumberImageFront { get; set; }
        [XmlElement("LP_IMAGE_BACK")]
        public String PlateNumberImageBack { get; set; }
        [XmlElement("DETAIL_IMAGE_FRONT")]
        public string DetailImageFront { get; set; }
        [XmlElement("DETAIL_IMAGE_BACK")]
        public string DetailImageBack { get; set; }
        [XmlElement("OVERVIEW_IMAGE")]
        public string OverviewImage { get; set; }

        [XmlElement("AXLES")]
        //[XmlArray("AXLES"), XmlArrayItem("AXLE", typeof(AxleDataInfor))]
        public AxlesInfor lstAxles { get; set; }
    }
}
