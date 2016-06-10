using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WIMSystemService.XmlElement;

namespace WIMSystemService.Request
{
    [XmlRoot("DOC")]
    public class Request_Resend_Data : CommunicationInfor
    {
        [XmlElement("REQ")]
        public Request_Resend_Doc RequestInfor { get; set; }

    }

    public class Request_Resend_Doc : RequestInfor
    {
        [XmlElement("SUBSYS_SPEC")]
        public Sub_Resend_Request Request { get; set; }
    }
    public class Sub_Resend_Request : RequestSubSpec
    {

    }
}
