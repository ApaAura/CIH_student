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

namespace Sarcina_3
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
            string selected = Anotimpuri.Text;
            switch (selected)
            {
                case "Iarna": Text.Text = "Ianuarie\nFebruarie\nDecembrie"; break;
                case "Primavara": Text.Text = "Martie\nAprilie\nMai"; break;
                case "Vara": Text.Text = "Iunie\nIulie\nAugust"; break;
                case "Toamna": Text.Text = "Septembrie\nOctombrie\nNoiembrie"; break;

                default: Text.Text = "Nu ati facut o selectie !";
                    break;
            }
        }
    }
}
