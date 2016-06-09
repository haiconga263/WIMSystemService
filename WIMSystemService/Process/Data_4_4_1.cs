using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WIMSystemService.XmlElement;

namespace WIMSystemService.Process
{
    public class DevDataInFor4_1 : DeviceDataInfor
    {
        [XmlArray("STATUSES")]
        [XmlArrayItem("STATUS",typeof(Status))]
        public List<Status> lstStatus { get; set; }

        [XmlElement("SUB_DATA")]
        public SubDataWithoutAggregation SubDatawithAggregation { get; set; }
    }


    public class RequestError4_1:RequestError
    {
        [XmlArray("REQUEST_ERRORS")]
        [XmlArrayItem("ERROR",typeof(RequestError))]
        public List<RequestError> lstRequestError { get; set; }
        [XmlAttribute("ERROR")]
        public List<string>lstError  { get; set; }
    }
    [XmlRoot("DOC")]
    public class Data_4_4_1 : CommunicationInfor
    {
        [XmlElement("DEV_DATA")]
        public DevDataInFor4_1 DevDataInfor { get; set; }
    }
    
}
