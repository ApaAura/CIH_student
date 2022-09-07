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

namespace Problema_9
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
        private void btApasa_Click(object sender, RoutedEventArgs e)
        {
            if (tbNume.Text == "")
            {
                MessageBox.Show("Introduceți numele!");
                tbNume.Focus();
            }
            else
            {
                tblRezultat.Text = "Buna ziua, " + tbNume.Text;
                tbNume.Clear();
            }
        }
    }
}
