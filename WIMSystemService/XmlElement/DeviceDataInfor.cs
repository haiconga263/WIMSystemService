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
        public String FirtDetectionTime { get; set; }
        [XmlElement("LAST_DETECTION_TIME")]
        public String LastDetectionTime { get; set; }
        [XmlElement("VEHICLES_COUNT")]
        public int VehicleCount { get; set; }

        //[XmlElement("SUB_DATA")]
        //public SubsystemInfor SubData { get; set; }

    }

    public class Status
    {
         [XmlAttribute("value")]
        public int Value { get; set; }
         [XmlAttribute("description")]
        public string Description { get; set; }
    }

    public class RequestError: RequestInforCommon
    {
        [XmlAttribute("type")]
        public string Type { get; set; }
        [XmlAttribute("number")]
        public int Number { get; set; }
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
        public int TotalLanes { get; set; }
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
        public int SubSytemNumber { get; set; }
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
        public int Confidence { get; set; }

    }

    public class AggregationInfoBase
    {
        [XmlElement("ALL")]
        public int All { get; set; }
        [XmlElement("CLASS")]
        public int Class { get; set; }
    }
}
