using System;
using System.Xml.Serialization;

namespace WIMSystemService.XmlElement
{
    public class RequestInforCommon
    {
        [XmlAttribute("sender")]
        public string Sender { get; set; }
        [XmlAttribute("receiver")]
        public string Receiver { get; set; }
        [XmlAttribute("device_type")]
        public string DeviceType { get; set; }
        
        
    }

    public class RequestInfor: RequestInforCommon
    {
        [XmlAttribute("data_type")]
        public string DataType { get; set; }
        [XmlAttribute("start_time")]
        public string StartTime { get; set; }
        [XmlAttribute("stop_time")]
        public string StopTime { get; set; }
    }

    public class RequestSubSpec: RequestInfor
    {
        [XmlElement("SUBSYS_SPEC")]
        public SubsystemInfor SubSystemSpec { get; set; }
    }

    public class SubsystemInfor
    {
         [XmlAttribute("subsys")]
        public string SubSystem { get; set; }
         [XmlAttribute("subsys_type")]
        public string SubSystemType { get; set; }
    }
}
