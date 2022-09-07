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

namespace Problema_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBlock txtMesaj = new TextBlock();
        Button cmdApasa = new Button();
        public MainWindow()
        {
            InitializeComponent();
            ColumnDefinition coloana1 = new ColumnDefinition();
            ColumnDefinition coloana2 = new ColumnDefinition();
            aspectGrid.ColumnDefinitions.Add(coloana1);
            aspectGrid.ColumnDefinitions.Add(coloana2);

            cmdApasa.Content = "Apasa";
            cmdApasa.Margin = new Thickness(20);
            cmdApasa.FontSize = 34;
            cmdApasa.Padding = new Thickness(20);
            cmdApasa.HorizontalAlignment = HorizontalAlignment.Center;
            cmdApasa.VerticalAlignment = VerticalAlignment.Center;
            cmdApasa.Click += new RoutedEventHandler(cmdApasaClick);

            Grid.SetColumn(cmdApasa, 0);
            aspectGrid.Children.Add(cmdApasa);

            txtMesaj.Margin = new Thickness(10);
            txtMesaj.HorizontalAlignment = HorizontalAlignment.Center;
            txtMesaj.VerticalAlignment = VerticalAlignment.Center;
            txtMesaj.Foreground = Brushes.Teal;
            txtMesaj.FontSize = 48;
            Grid.SetColumn(txtMesaj, 1);
            aspectGrid.Children.Add(txtMesaj);
        }
        private void cmdApasaClick(object sender, RoutedEventArgs e)
        {
            txtMesaj.Text = "Studiem WPF!";
        }
    }
}
