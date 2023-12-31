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

namespace WpfGraphics2dApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Polygon pg = new Polygon();
            pg.Points = new PointCollection();
            pg.Points.Add(new Point(5, 150));
            pg.Points.Add(new Point(100, 100));
            pg.Points.Add(new Point(200, 200));
            pg.Fill = new SolidColorBrush(Colors.Magenta);
            stack.Children.Add(pg);
        }
    }
}
