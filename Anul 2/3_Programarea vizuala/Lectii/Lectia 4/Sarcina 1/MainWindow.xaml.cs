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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Figuri.SelectedItem.ToString().Contains("Cerc"))
            {
                try
                {
                    double r = double.Parse(CercRaza.Text);
                    double per = 2 * Math.PI * r;
                    double ari = Math.PI * r * r;
                    Perim.Content = $"Perimetrul: {per:F3}";
                    Aria.Content = $"Aria: {ari:F3}";
                }catch (Exception ex)
                {
                    MessageBox.Show("Raza trebuie sa fie un numar");
                }
            }
            if (Figuri.SelectedItem.ToString().Contains("Paralelogram"))
            {
                try
                {
                    double baza = double.Parse(ParBaza.Text);
                    double latura = double.Parse(ParLatura.Text);
                    double inaltime = double.Parse(ParInaltime.Text);

                    double per = 2 * (latura + baza);
                    double ari = baza * inaltime;
                    Perim.Content = $"Perimetrul: {per:F3}";
                    Aria.Content = $"Aria: {ari:F3}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Laturile cerute trebuie sa fie numere");
                }
            }
        }

        private void Figuri_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Figuri.SelectedItem.ToString().Contains("Cerc"))
            {
                BtnCalc.IsEnabled = true;
                CircleData.Visibility = Visibility.Visible;
                ParalelogramData.Visibility = Visibility.Collapsed;
            }
            if (Figuri.SelectedItem.ToString().Contains("Paralelogram"))
            {
                BtnCalc.IsEnabled = true;
                CircleData.Visibility = Visibility.Collapsed;
                ParalelogramData.Visibility = Visibility.Visible;
            }
        }
    }
}
