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

namespace Wpfteht3
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

        private void Laske_Click(object sender, RoutedEventArgs e)
        {
            int alaIkkuna = int.Parse(ikkunanLeveys.Text) * int.Parse(ikkunanKorkeus.Text);
            
            ikkunanAla.Text = (alaIkkuna / 10).ToString() + " cm2";

            int alaLasi = (int.Parse(ikkunanLeveys.Text) - (2 * int.Parse(karminLeveys.Text)))
                            * (int.Parse(ikkunanKorkeus.Text) - (2 * int.Parse(karminLeveys.Text)));
            lasinAla.Text = (alaLasi / 10).ToString() + " cm2";

            int piiriKarmi = 2 * (int.Parse(ikkunanLeveys.Text) + int.Parse(ikkunanKorkeus.Text));
            karminPiiri.Text = (piiriKarmi / 10).ToString() + " cm";
        }
    }
}
