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
    public class Request_Config : CommunicationInfor
    {
        [XmlElement("REQ")]
        public Request_Config_Doc RequestInfor { get; set; }

    }

    public class Request_Config_Doc : RequestInforCommon
    {
      
    }
    
}
