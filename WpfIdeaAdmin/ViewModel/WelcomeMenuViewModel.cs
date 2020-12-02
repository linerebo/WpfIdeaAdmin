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
    public class WelcomeMenuViewModel
    {
        public List<Customer> MyCustomers { get; set; }
        public WelcomeMenuViewModel()
        {
            MyCustomers = new List<Customer>();

            Customer customer1 = new Customer();
            customer1.Name = "Slikbutikken";
            customer1.Status = true;

            Customer customer2 = new Customer();
            customer2.Name = "SkoShop";
            customer2.Status = false;

            MyCustomers.Add(customer1);
            MyCustomers.Add(customer2);

        }
        
        

        public ICommand AddCustomerCmd => new CustomerCommand(
            () =>
            {
                ((App)App.Current).ContentControlRef.Content = new AddCustomerView();
            });

        public ICommand CreateURLCmd => new CustomerCommand(
            () =>
            {
                ((App)App.Current).ContentControlRef.Content = new CreateUrlView();
            });

        public ICommand EditCustomerCmd => new CustomerCommand(
            () =>
            {
                ((App)App.Current).ContentControlRef.Content = new AddCustomerView();
            });

        public ICommand DeactivateCustomerCmd => new CustomerCommand(
            () =>
            {
                ((App)App.Current).ContentControlRef.Content = new AddCustomerView();
            });
    }
}
