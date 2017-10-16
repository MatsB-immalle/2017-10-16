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

namespace WpfApp13
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

        private void Mijnknop_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush1 = new SolidColorBrush(Colors.Black);
            SolidColorBrush brush2 = new SolidColorBrush(Colors.Green);
            SolidColorBrush brush3 = new SolidColorBrush(Colors.Red);

            Drawtriangle(50, 50, 50, 200, brush1);
            Drawtriangle(50, 50, 200, 50, brush2);
            Drawtriangle(200, 50, 50, 200, brush3);


        }

        private void Drawtriangle(int x1, int y1, int x2, int y2, SolidColorBrush brushToUse)
        {
            Line lijn1 = new Line();

            lijn1.X1 = x1;
            lijn1.Y1 = y1;
            lijn1.X2 = x2;
            lijn1.Y2 = y2;            
            lijn1.Stroke = brushToUse;
            mijncanvas.Children.Add(lijn1);
        }
    }
}
