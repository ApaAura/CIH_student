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

namespace Sarcina_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Count { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Count = 0;
        }

        private void Button(object sender, RoutedEventArgs e)
        {
            Count++;
            label1.Content = $"{Count}";
        }
        private void Button1(object sender, RoutedEventArgs e)
        {
            Count--;
            label1.Content = $"{Count}";
        }
    }
}
