using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Xml.Serialization;

namespace WIMSystemService.XmlElement
{
    public class DeviceDataInfor : RequestInfor
    {
        [XmlElement("DEVICE")]
        public DeviceInfor Device { get; set; }
        [XmlElement("FIRST_DETECTION_TIME")]
        public string FirtDetectionTime { get; set; }
        [XmlElement("LAST_DETECTION_TIME")]
        public string LastDetectionTime { get; set; }
        [XmlElement("VEHICLES_COUNT")]
        public string VehicleCount { get; set; }
    }

    public class Status
    {
        [XmlAttribute("value")]
        public string Value { get; set; }
        [XmlAttribute("description")]
        public string Description { get; set; }
    }

    public class RequestError : RequestInforCommon
    {
        [XmlAttribute("type")]
        public string Type { get; set; }
        [XmlAttribute("number")]
        public string Number { get; set; }
        [XmlAttribute("send_time")]
        public string SendTime { get; set; }
    }

    public class DeviceInfor
    {
        [XmlAttribute("location")]
        public string Location { get; set; }
        [XmlAttribute("vehicle_class")]
        public string VehicleClass { get; set; }
        [XmlAttribute("total_lanes")]
        public string TotalLanes { get; set; }
    }

    public class SubSystemData
    {
        [XmlAttribute("subsys")]
        public string SubSystem { get; set; }

        [XmlAttribute("subsys_type")]
        public string SubSystemType { get; set; }

        [XmlElement("STATUSES")]
        public List<Status> Statuses { get; set; }
    }

    public class SubDataWithoutAggregation : SubSystemData
    {
        [XmlAttribute("subsys_number")]
        public string SubSytemNumber { get; set; }
        [XmlElement("VEHICLE")]
        public List<VehicleDataInfor> ListVehicle { get; set; }
    }

    public class SubDatawithAggregation : SubSystemData
    {
        [XmlElement("INTENSITY")]
        public AggregationInfoBase Intensity { get; set; }
        [XmlElement("OCCUPANCY")]
        public AggregationInfoBase Occupancy { get; set; }
        [XmlElement("VELOCITY")]
        public AggregationInfoBase Velocity { get; set; }

        [XmlElement("CONFIDENCE")]
        public string Confidence { get; set; }
    }
    public class myClass
    {
        [XmlAttribute("id")]
        public string ID { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
    //public  class All
    //{
    //    [XmlText]
    //    public  string Value { get; set; }
    //}
    ////public class Intensity:AggregationInfoBase
    //{
    //    //[XmlElement("ALL")]
    //    //public All ALL { get; set; }

    //    //[XmlElement]

    //    //public myClass LstClass { get; set; }
    //}
    //public class Occupancy : AggregationInfoBase
    //{
    //    //[XmlElement("ALL")]
    //    //public All ALL { get; set; }

    //    //[XmlElement]

    //    //public myClass LstClass { get; set; }
    //}

    public class AggregationInfoBase
    {
        [XmlElement("ALL")]
        public string All { get; set; }
        [XmlElement("CLASS")]    
        public List<myClass> LstClass { get; set; }

    }
}
