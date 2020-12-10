﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfIdeaAdmin.View;
using WpfIdeaAdmin.ViewModel;

namespace WpfIdeaAdmin
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public ContentControl ContentControlRef { get; set; } = null;
        public AdministratorViewModel viewmodel = new AdministratorViewModel();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

           
        }
    }
}
