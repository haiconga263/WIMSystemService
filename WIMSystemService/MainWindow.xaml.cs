using System;
using System.IO;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;
using WIMSystemService.Deserializer;
using WIMSystemService.Process;
using WIMSystemService.Request;

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
           object data = SerializerObject.Check("Data_Aggregation_Type.XML");
        }

        private void BrowseXmlFile(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.CheckFileExists = true;
            dlg.Filter = "XML Files (*.xml)|*.xml|All Files(*.*)|*.*";
            dlg.Multiselect = false;

            if (dlg.ShowDialog() != true) { return; }

            XmlDocument XMLdoc = new XmlDocument();
            try
            {
                XMLdoc.Load(dlg.FileName);
            }
            catch (XmlException xmlEx)
            {
                MessageBox.Show(xmlEx.ToString());
                return;
            }

            txtFileLoad.Text = dlg.FileName;
            vxmlBefore.xmlDocument = XMLdoc;

        }

        private void Refesh_Click(object sender, RoutedEventArgs e)
        {
            if (txtFileLoad.Text == "")
            {
                MessageBox.Show("Bạn chưa load gói tin");
                return;
            }

            string pathSave = "Result.XML";

            ///XMl -> Obj -> XML
            var obj = SerializerObject.Check(txtFileLoad.Text);
            Serialize(pathSave, obj, obj.GetType());

            XmlDocument XMLdoc = new XmlDocument();
            try
            {
                XMLdoc.Load(pathSave);
            }
            catch (XmlException xmlex)
            {
                MessageBox.Show(xmlex.ToString());
                return;
            }
            vxmlAtfer.xmlDocument = XMLdoc;
        }

        private void Serialize(string desFile, object obj, Type T)
        {
            TextWriter writer = new StreamWriter(desFile);
            var xmlSerializer = new XmlSerializer(T);
            xmlSerializer.Serialize(writer, obj);
            writer.Close();
        }

        private object Deserialize(string src, Type T)
        {
            TextReader reader = new StreamReader(src);

            var xmlSerializer = new XmlSerializer(T);
            var obj = xmlSerializer.Deserialize(reader);
            reader.Close();
            return obj;
        }
    }
}
