﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfIdeaAdmin.Model;
using WpfIdeaAdmin.View;
using WpfIdeaAdmin.ViewModel.Commands;

namespace WpfIdeaAdmin.ViewModel
{
    public class DeleteCustomerViewModel
    {
        private SingletonSharedData singleSharedData;
        public Model.ApiHelper apiHelperSingleton { get; set; }
        public DeleteCustomerViewModel()
        {
            singleSharedData = SingletonSharedData.getInstance();
            apiHelperSingleton = new ApiHelper();
        }

        public ICommand DeactivateCmd => new CustomerCommand(
            () =>
            {
                ((App)App.Current).ContentControlRef.Content = new WelcomeMenuView();
            });

        public ICommand CancelCmd => new CustomerCommand(
            () =>
            {
                ((App)App.Current).ContentControlRef.Content = new WelcomeMenuView();
            });

        public ICommand DeleteCmd => new CustomerCommand(
            () =>
            {
                ((App)App.Current).ContentControlRef.Content = new WelcomeMenuView();
            });
    }
}
