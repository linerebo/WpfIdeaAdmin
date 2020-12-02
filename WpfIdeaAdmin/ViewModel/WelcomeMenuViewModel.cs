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

            MyCustomers.Add(new Customer() { Name = "Idefabrikken", Street = "Hovedgaden", Mail = "ide@mail.com", Phone = "123456789", Zipcode = "6000", City = "Lilleby", Status = true }) ;
            MyCustomers.Add(new Customer() { Name = "Slikbutikken", Street = "Hovedgaden", Mail = "is@mail.com", Phone = "123456789", Zipcode = "9000", City = "Storeby", Status = true });
            MyCustomers.Add(new Customer() { Name = "Skoshop", Street = "Hovedgaden", Mail = "sko@mail.com", Phone = "123456789", Zipcode = "2000", City = "Mellemby", Status = false });
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
