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
    public class ViewModelMainWindow
    {
        public ICommand AddCustomerCmd => new CustomerCommand(
            () =>
            {
                Console.WriteLine("this is with ICommand!");
                Slide2 slide2 = new Slide2();
                slide2.Show();
            });
    }
}
