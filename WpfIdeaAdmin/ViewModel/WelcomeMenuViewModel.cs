using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfIdeaAdmin.View;
using WpfIdeaAdmin.ViewModel.Commands;

namespace WpfIdeaAdmin.ViewModel
{
    public class WelcomeMenuViewModel
    {
        public ICommand AddCustomerCmd => new CustomerCommand(
            () =>
            {
                Console.WriteLine("This is with ICommand!");
                ((App)App.Current).ContentControlRef.Content = new AddCustomerView();
            });

        public ICommand CreateURLCmd => new CustomerCommand(
            () =>
            {
                Console.WriteLine("This is with ICommand!");
                ((App)App.Current).ContentControlRef.Content = new CreateUrlView();
            });

        public ICommand EditCustomerCmd => new CustomerCommand(
            () =>
            {
                Console.WriteLine("This is with ICommand!");
                ((App)App.Current).ContentControlRef.Content = new AddCustomerView();
            });

        public ICommand DeactivateCustomerCmd => new CustomerCommand(
            () =>
            {
                Console.WriteLine("This is with ICommand!");
                ((App)App.Current).ContentControlRef.Content = new AddCustomerView();
            });
    }
}
