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

namespace HW4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ux_Submit.IsEnabled = false;
        }

        private void uxName_TextChanged(object sender, TextChangedEventArgs e)
        {

            int sw = UserInput.Text.Length;
            int i = 0;
            switch (sw)
            {
                // US Zip Codes #####
                case 5:
                    ux_Submit.IsEnabled = int.TryParse(UserInput.Text, out i);
                    break;
                // Canadian Postal Codes: A#B#C#
                case 6:
                    ux_Submit.IsEnabled = int.TryParse(UserInput.Text, out i);
                    break;
                // US Zip Codes #####-####
                case 10:
                    ux_Submit.IsEnabled = int.TryParse(UserInput.Text.Substring(0,5), out i) && 
                                          int.TryParse(UserInput.Text.Substring(6, 4), out i) &&
                                          UserInput.Text.Substring(5,1) == "-";
                    break;
                default:
                    ux_Submit.IsEnabled = false;
                    break;
            }
        }

        private void ux_Submit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Searching");
        }
    }
}
