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

namespace Problema_4
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
        private void cbExemplu4_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(cbExemplu4.Content.ToString() + " Nu este selectat");
        }
        private void cbExemplu4_Indeterminate(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(cbExemplu4.Content.ToString() + " Nedeterminat");
        }
        private void cbExemplu4_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(cbExemplu4.Content.ToString() + " Este selectat");
        }
    }
}