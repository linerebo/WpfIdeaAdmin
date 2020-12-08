using System;
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
    public class CreateUrlViewModel
    {
         
        public ICommand SendCmd => new CustomerCommand(
            () =>
            {
                ((App)App.Current).ContentControlRef.Content = new AddCustomerView();
            });

        public ICommand CancelCmd => new CustomerCommand(
            () =>
            {
                ((App)App.Current).ContentControlRef.Content = new AddCustomerView();
            });
    }
}
