﻿using System;
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

namespace Wpfteht1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int trucks = 0;
        int cars = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void truckButton_Click(object sender, RoutedEventArgs e)
        {
            trucks++;
            truckCount.Text = trucks.ToString();
        }

        private void carButton_Click(object sender, RoutedEventArgs e)
        {
            cars++;
            carCount.Text = cars.ToString();
        }
    }
}
