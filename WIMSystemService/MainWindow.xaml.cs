using System;
using System.IO;
using System.Windows;
using WIMSystemService.Deserializer;
using WIMSystemService.Process;
using WIMSystemService.Request;
using WIMSystemService.Serializer;

namespace WIMSystemService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Request_Resend_Data rsd = new Request_Resend_Data { Number="123",RequestInfor= new Request_Resend_Doc { DataType = "1", Request = new Sub_Resend_Request {StartTime = "1234" } }, SendTime = "123", Transmission = "1" };
            //Request_Data rq = new Request_Data { Number = "123", Type = "123", RequestInfor = new Request_Doc { Receiver = "123", Sender = "123", Request = new Sub_Request { SubSystemSpec = new XmlElement.SubsystemInfor { SubSystem = "123", SubSystemType = "231" } } } };
            try
            {
                //MySerializerXML<Request_Resend_Data>.Serialize(rsd, "thai");

                Pro_Alarm_Overweight dt = DeserializerXML<Pro_Alarm_Overweight>.Deserializer("demoxml.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }

        }
    }
}
