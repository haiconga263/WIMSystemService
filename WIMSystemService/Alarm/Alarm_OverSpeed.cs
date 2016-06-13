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
    public  class Alarm_OverSpeed : CommunicationInfor
    {
        [XmlElement("DEV_DATA")]
        public DevData_Over DevDataInfor { get; set; }
    }

    public class DevData_Over : RequestSubSpec
    {
        [XmlElement("SUB_DATA")]
        public Sub_SystemInfor Sub_Data { get; set; }
    }
    public class Sub_SystemInfor : SubsystemInfor
    {
        [XmlElement("ALARM")]
        public OverspeedAlarm Over { get; set; }
    }
}
