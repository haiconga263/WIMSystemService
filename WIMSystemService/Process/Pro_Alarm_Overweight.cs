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
    public class Pro_Alarm_Overweight : CommunicationInfor
    {
        [XmlElement("DEV_DATA")]
        public DevData_OverW DevDataInfor { get; set; }
    }

    public class DevData_OverW : RequestSubSpec
    {
        [XmlElement("SUB_DATA")]
        public Pro_SubsystemInfor_W Sub_Data { get; set; }
    }
    public class Pro_SubsystemInfor_W : SubsystemInfor
    {
        [XmlElement("ALARM")]
        public OverWeightAlarm OverW { get; set; }
    }
}
