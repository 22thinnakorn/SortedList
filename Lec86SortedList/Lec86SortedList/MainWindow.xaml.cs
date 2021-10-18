using System;
using System.Collections;
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

namespace Lec86SortedList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;
        public MainWindow()
        {
            sortedList = new SortedList();
            InitializeComponent();
        }

        private void showtbn_Click(object sender, RoutedEventArgs e)
        {
            string data1 = "";
            sortedList.Add(keytxt.Text, valuetxt.Text);
            ICollection collection = sortedList.Keys;
            foreach(string key in collection)
            {
               data1 = data1 + sortedList[key].ToString()+"\n";
            }
            MessageBox.Show(data1);
                   
        }
    }
}
