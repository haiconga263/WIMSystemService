using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WIMSystemService.XmlElement;

namespace WIMSystemService.Receive_Data
{
    [XmlRoot("DOC")]
    public class Message_Config : CommunicationInfor
    {
        [XmlElement("DEVICE_TYPE")]
        public List<DeviceType_Infor> DeviceTypeInfor { get; set; }
    }

    public class DeviceType_Infor : DeviceTypeInfor
    {
        [XmlElement("DEVICE")]
        public List<SubSystemType> SubSysType { get; set; }
    }

    public class SubSystemType : ConfigDevice
    {
        [XmlElement("SUBSYS_TYPE")]
        public SubSystem SubSys { get; set; }
    }

    public class SubSystem : ConfigDevice
    {
        [XmlElement("SUBSYS")]
        public List<ConfigDevice> ListSubSys { get; set; }
    }
}
