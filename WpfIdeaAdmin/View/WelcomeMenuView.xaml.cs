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
using WpfIdeaAdmin.ViewModel;

namespace WpfIdeaAdmin.View
{
    /// <summary>
    /// Interaction logic for WelcomeMenuView.xaml
    /// </summary>
    public partial class WelcomeMenuView : UserControl
    {
        public WelcomeMenuView()
        {
            InitializeComponent();
            this.DataContext = new WelcomeMenuViewModel();
        }
    }
}
