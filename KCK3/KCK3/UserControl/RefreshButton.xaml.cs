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

namespace KCK3.UserControl
{
    /// <summary>
    /// Interaction logic for RefreshButton.xaml
    /// </summary>
    public partial class RefreshButton 
    {
        public RefreshButton()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ProgresBar wind = new ProgresBar();
            wind.ShowDialog();
           
        }
    }
}
