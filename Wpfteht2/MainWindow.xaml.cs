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

namespace Wpfteht2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        double money = 0;
        double kurssi = 5.94573;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void toMarkka_Click(object sender, RoutedEventArgs e)
        {
            string retval = amount.Text;
            double.TryParse(retval, out money);
            money = money * kurssi;
            string value = money.ToString("0.00"); // Two desimals.
            converted.Text = value + " mk";
        }

        private void toEuro_Click(object sender, RoutedEventArgs e)
        {
            string retval = amount.Text;
            double.TryParse(retval, out money);
            money = money / kurssi;
            string value = money.ToString("0.00"); // Two desimals.
            converted.Text = value + "€";
        }

        private void amount_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox amount = (TextBox)sender;
            amount.Text = string.Empty;
            amount.GotFocus -= amount_GotFocus;
        }
    }
}
