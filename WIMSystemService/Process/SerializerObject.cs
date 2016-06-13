using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WIMSystemService.Deserializer;
using WIMSystemService.Receive_Data;
using WIMSystemService.Request;
using WIMSystemService.XmlElement;

namespace WIMSystemService.Process
{
    public class SerializerObject
    {
        public static object Check(string Name)
        {
            using (TextReader reader = new StreamReader(Name))
            {
                try
                {
                    Alarm_OverSpeed data = DeserializerXML<Alarm_OverSpeed>.Deserializer(Name);
                    switch (data.Type)
                    {
                        case "config":
                            Message_Config dataConfig = DeserializerXML<Message_Config>.Deserializer(Name);
                            return dataConfig;

                        case "data":
                            {

                                if (data.DevDataInfor.DataType == "5min" || data.DevDataInfor.DataType == "hour")
                                {
                                    DataAggregationType dataAggregationType = DeserializerXML<DataAggregationType>.Deserializer(Name);
                                    return dataAggregationType;
                                }
                                else if (data.DevDataInfor.DataType == "event")
                                {
                                    DataAggregation dataAggregation = DeserializerXML<DataAggregation>.Deserializer(Name);
                                    return dataAggregation;
                                }
                                break;
                            }

                        case "alarm_occured":
                            {
                                if (int.Parse(data.DevDataInfor.Sub_Data.Over.Value) == 1)
                                {

                                    Alarm_OverSpeed dataAlarmOccured = DeserializerXML<Alarm_OverSpeed>.Deserializer(Name);
                                    return dataAlarmOccured;

                                }
                                else if (int.Parse(data.DevDataInfor.Sub_Data.Over.Value) == 2)
                                {
                                    Alarm_Overweight dataAlarmOccured = DeserializerXML<Alarm_Overweight>.Deserializer(Name);
                                    return dataAlarmOccured;
                                }
                                break;
                            }

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return null;

        }
    }
}
