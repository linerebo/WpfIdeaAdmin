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
    public class AddCustomerViewModel
    {
        public ICommand SaveCmd => new CustomerCommand(
            () =>
            {
                Console.WriteLine("This is with ICommand!");
                ((App)App.Current).ContentControlRef.Content = new WelcomeMenuView();
            });

        public ICommand CancelCmd => new CustomerCommand(
            () =>
            {
                Console.WriteLine("This is with ICommand!");
                ((App)App.Current).ContentControlRef.Content = new WelcomeMenuView();
            });
    }
}
