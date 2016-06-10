using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WIMSystemService.XmlElement;

namespace WIMSystemService.Process
{
    public class DevDataInFor4_2 : DeviceDataInfor
    {
        [XmlArray("STATUSES")]
        [XmlArrayItem("STATUS", typeof(Status))]
        public List<Status> lstStatus { get; set; }

        [XmlElement("SUB_DATA")]
        public SubDatawithAggregation SubDatawithAggregation { get; set; }
    }
    [XmlRoot("DOC")]
    public class Data_4_4_1_2: CommunicationInfor
    {
        [XmlElement("DEV_DATA")]
        public DevDataInFor4_2 DevDataInfor { get; set; }

    }
}
