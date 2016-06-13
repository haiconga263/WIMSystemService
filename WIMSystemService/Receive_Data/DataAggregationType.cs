using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WIMSystemService.XmlElement;

namespace WIMSystemService.Process
{
    public class DevDataInfor : DeviceDataInfor
    {
        [XmlArray("STATUSES")]
        [XmlArrayItem("STATUS", typeof(Status))]
        public List<Status> lstStatus { get; set; }

        [XmlElement("SUB_DATA")]
        public SubDatawithAggregation SubDatawithAggregation { get; set; }
    }
    [XmlRoot("DOC")]
    public class DataAggregationType : CommunicationInfor
    {
        [XmlElement("DEV_DATA")]
        public DevDataInfor DevDataInfor { get; set; }

    }
}
