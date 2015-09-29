using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Lab_1WPF_file
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            List<Point> src = new List<Point>();
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");


            if (openFileDialog.ShowDialog() == true)
            {
              var lines =   File.ReadLines(openFileDialog.FileName);

                    foreach (string t in lines)
                    {
                   
                    
                        var k = t.Split(',');
                        if( k.Length ==2 )
                            src.Add(new Point { X = double.Parse(k[0]), Y = double.Parse(k[1]) });
                    }

                  
                }  
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("ru-RU");

                resInput.Clear();
                foreach (Point x in src)
                {

                    resInput.Text += String.Format("X: {0} Y: {1}", x.X, x.Y) + "\n";
                }
                 //   lbFiles.Items.Add(Path.GetFileName(filename));
            }
        
    }
}
