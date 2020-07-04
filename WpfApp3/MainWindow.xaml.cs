using System;
using System.Collections.Generic;
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
using System.Xml.Linq;

namespace WpfApp3
{

    public partial class MainWindow : Window
    {
        public static string ImageLocation { get { return @"~\..\ImgFol\DEF2.jpg"; } set { ImageLocation = value; } }
     
        public MainWindow()
        {
           
            InitializeComponent();
        }
        



        private void catlist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dynamic id = catlist.SelectedValue;
            XmlDataProvider xmlDataProvider=(XmlDataProvider)this.FindResource("p2");
            Binding b2 = new Binding() { Source = xmlDataProvider, XPath = $"genre[@cid={id}]" };
            BindingOperations.SetBinding(list1, ListBox.ItemsSourceProperty,b2);
        }

        private void list1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dynamic id = list1.SelectedValue;
            XmlDataProvider xmlDataProvider = (XmlDataProvider)this.FindResource("p3");
            Binding b2 = new Binding() { Source = xmlDataProvider, XPath = $"book[@idchanr={id}]" };
            BindingOperations.SetBinding(list2, ListBox.ItemsSourceProperty, b2);
        }

 

        private void Button_Click(object sender, RoutedEventArgs e)
        {
    
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }


    }
}
