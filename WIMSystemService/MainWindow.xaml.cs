﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;
using WIMSystemService.Process;
using WIMSystemService.XmlElement;

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
            try
            {

                TextReader reader = new StreamReader("demoxml.xml");

                var xmlSerializer = new XmlSerializer(typeof(Data_4_4_1_1));
                Data_4_4_1_1 data = xmlSerializer.Deserialize(reader) as Data_4_4_1_1;

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }

        }
    }
}