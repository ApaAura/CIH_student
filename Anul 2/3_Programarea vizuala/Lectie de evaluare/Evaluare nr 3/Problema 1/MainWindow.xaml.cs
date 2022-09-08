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

namespace Problema_1
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
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            SetBackground(1);
        }
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            SetBackground(2);
        }
        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            SetBackground(3);
        }
        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            SetBackground(4);
        }
        public void SetBackground(byte nr)
        {
            ImageBrush myBrush = new ImageBrush();
            Image image = new Image();
            switch (nr)
            {
                case 1:
                    {
                        image.Source = new BitmapImage(new Uri("pack://application:,,,/images/1.jpg"));
                        myBrush.ImageSource = image.Source;
                        this.Background = myBrush;
                    }
                    break;
                case 2:
                    {
                        image.Source = new BitmapImage(new Uri("pack://application:,,,/images/2.jpg"));
                        myBrush.ImageSource = image.Source;
                        this.Background = myBrush;
                    }
                    break;
                case 3:
                    {
                        image.Source = new BitmapImage(new Uri("pack://application:,,,/images/3.jpg"));
                        myBrush.ImageSource = image.Source;
                        this.Background = myBrush;
                    }
                    break;
                case 4:
                    {
                        
                        image.Source = new BitmapImage(new Uri("pack://application:,,,/images/4.jpg"));
                        myBrush.ImageSource = image.Source;
                        this.Background = myBrush;
                    }
                    break;
                default:
                    break;
            }
        }
        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateOnly DataSelected = new DateOnly(DataZodie.SelectedDate.Value.Year, DataZodie.SelectedDate.Value.Month, DataZodie.SelectedDate.Value.Day);
            MessageBox.Show($"{zodiac_sign(DataSelected.Day, DataSelected.Month)}");
        }
        string zodiac_sign(int day, int month)
        {
            string zodiac = "";
            if (month == 12)
            {

                if (day < 22)
                    zodiac = "Sagetator";
                else
                    zodiac = "Capricorn";
            }

            else if (month == 1)
            {
                if (day < 20)
                    zodiac = "Capricorn";
                else
                    zodiac = "Aquarius";
            }

            else if (month == 2)
            {
                if (day < 19)
                    zodiac = "Aquarius";
                else
                    zodiac = "Pesti";
            }

            else if (month == 3)
            {
                if (day < 21)
                    zodiac = "Pesti";
                else
                    zodiac = "Berbec";
            }
            else if (month == 4)
            {
                if (day < 20)
                    zodiac = "Berbec";
                else
                    zodiac = "Taur";
            }

            else if (month == 5)
            {
                if (day < 21)
                    zodiac = "Taur";
                else
                    zodiac = "Gemeni";
            }

            else if (month == 6)
            {
                if (day < 21)
                    zodiac = "Gemeni";
                else
                    zodiac = "Rac";
            }

            else if (month == 7)
            {
                if (day < 23)
                    zodiac = "Rac";
                else
                    zodiac = "Leu";
            }

            else if (month == 8)
            {
                if (day < 23)
                    zodiac = "Leu";
                else
                    zodiac = "Fecioara";
            }

            else if (month == 9)
            {
                if (day < 23)
                    zodiac = "Feciaora";
                else
                    zodiac = "Balanta";
            }

            else if (month == 10)
            {
                if (day < 23)
                    zodiac = "Balanta";
                else
                    zodiac = "Scorpion";
            }

            else if (month == 11)
            {
                if (day < 22)
                    zodiac = "Scorpion";
                else
                    zodiac = "Sagetator";
            }

            return zodiac;
        }
    }
}
