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
    public class CreateUrlViewModel : Bindable
    {
        private SingletonSharedData singleSharedData;
        public Model.ApiHelper apiHelperSingleton { get; set; }
        public Customer SelectedCustomer { get; set; }

        public CreateUrlViewModel()
        {
            singleSharedData = SingletonSharedData.getInstance();
            apiHelperSingleton = new ApiHelper();
            SelectedCustomer = new Customer();
        }
         
        public ICommand SendCmd => new CustomerCommand(
            () =>
            {
                //Console.WriteLine("SelectedCustomer fra url: " + singleSharedData.SelectedCustomer.CustomerName);
                //Console.WriteLine("SelectedCustomer fra url viewmodel: " + SingletonSharedData.getInstance().SelectedCustomer.CustomerName);
                ((App)App.Current).ContentControlRef.Content = new WelcomeMenuView();
            });

        public ICommand CancelCmd => new CustomerCommand(
            () =>
            {
                ((App)App.Current).ContentControlRef.Content = new WelcomeMenuView();
            });
    }
}
