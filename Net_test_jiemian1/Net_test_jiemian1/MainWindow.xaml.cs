using NLECloudSDK;
using NLECloudSDK.Model;
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

namespace Net_test_jiemian1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Form3 f3 = null;
        private Form2 f2 = null;
        private Form4 f4 = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            f3 = new Form3();
            f3.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            f2 = new Form2();
            f2.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            f4 = new Form4();
            f4.Show();
        }
    }
}
