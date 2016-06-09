using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace WIMSystemService.XmlElement
{

    public class AlarmDataInfor
    {
        [XmlAttribute("value")]
        public string Value { get; set; }
        [XmlAttribute("description")]
        public string Description { get; set; }

        [XmlElement("CLASS")]
        public myClass Class { get; set; }
        [XmlElement("TIME")]
        public string DetectionTime { get; set; }
        [XmlElement("LP_FRONT")]
        public string PlateNumberFront { get; set; }
        [XmlElement("LP_FRONT_ILPC")]
        public string PlateNumberFrontIlpc { get; set; }
        [XmlElement("LP_BACK")]
        public string PlateNumberBack { get; set; }
        [XmlElement("LP_BACK_ILPC")]
        public string PlateNumberBackIlpc { get; set; }
        [XmlElement("LP_IMAGE_FRONT")]
        public string PlateNumberImageFront { get; set; }
        [XmlElement("LP_IMAGE_BACK")]
        public string PlateNumberImageBack { get; set; }
        [XmlElement("DETAIL_IMAGE_FRONT")]
        public string DetailImageFront { get; set; }
        [XmlElement("DETAIL_IMAGE_BACK")]
        public string DetailImageBack { get; set; }
        [XmlElement("OVERVIEW_IMAGE")]
        public string OverviewImage { get; set; }
    }

    public class OverspeedAlarm : AlarmDataInfor
    {
        
        [XmlElement("OVERSPEED")]
        public OverSpeedInfor OverSpeed { get; set; }
    }

    public class OverWeightAlarm : AlarmDataInfor
    {
        [XmlArray("OVERWEIGHTS")]
        [XmlArrayItem("OVERWEIGHT")]
        public List<OverWeightInfor> OverWeights { get; set; }
        [XmlElement("WIM_INFO")]
        public WimDataInfo WimInfo { get; set; }

    }

    public class OverSpeedInfor
    {
        [XmlAttribute("speed_limit")]
        public string SpeedLimit { get; set; }
        [XmlAttribute("speed_measured")]
        public string SpeedMeasure  { get; set; }
    }

    public class OverWeightInfor
    {
        //[XmlArrayItem("OVERWEIGHT")]
        //public string OverWeight { get; set; }
        [XmlAttribute("type")]
        public string Type { get; set; }
        [XmlAttribute("weight_limit")]
        public string Weight_limit { get; set; }
        [XmlAttribute("weight_measured")]
        public string Weight_measured { get; set; }
    }
}
