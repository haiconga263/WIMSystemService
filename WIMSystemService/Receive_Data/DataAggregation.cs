using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WIMSystemService.XmlElement;

namespace WIMSystemService.Process
{
    [XmlRoot("DOC")]
    public class DataAggregation : CommunicationInfor
    {
        [XmlElement("DEV_DATA")]
        public DevDataInFor DevDataInfor { get; set; }

        [XmlElement("REQUEST_ERRORS")]
        public RequestErrorData RequestErrorData { get; set; }
    }

    public class RequestErrorData : RequestError
    {
        [XmlArray("REQUEST_ERRORS")]
        [XmlArrayItem("ERROR", typeof(RequestError))]
        public List<RequestError> lstRequestError { get; set; }
        [XmlAttribute("ERROR")]
        public List<string> lstError { get; set; }
    }
    public class DevDataInFor : DeviceDataInfor
    {
        [XmlArray("STATUSES")]
        [XmlArrayItem("STATUS", typeof(Status))]
        public List<Status> lstStatus { get; set; }

        [XmlElement("SUB_DATA")]
        public SubDataWithoutAggregation SubDatawithAggregation { get; set; }
    }
}
