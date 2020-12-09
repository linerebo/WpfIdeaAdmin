using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfIdeaAdmin.Model;
using WpfIdeaAdmin.View;
using WpfIdeaAdmin.ViewModel.Commands;

namespace WpfIdeaAdmin.ViewModel
{
    public class AdministratorViewModel
    {
        public List<Customer> MyCustomerList { get; set; }
        public Customer SelectedCustomer { get; set; }
        public Model.ApiHelper apiHelperSingleton { get; set; }
        
        public AdministratorViewModel()
        {
            apiHelperSingleton = new ApiHelper();
            Task gcTask = apiHelperSingleton.getCustomers();
            gcTask.Wait();
            
            //old test data
            //MyCustomerList.Add(new Customer() { CustomerID = 20, Name = "Idefabrikken", Street = "Hovedgaden", Mail = "ide@mail.com", Phone = "123456789", Zipcode = "6000", City = "Lilleby", Status = true }) ;
            //MyCustomers.Add(new Customer() {CustomerID = 21, Name = "Slikbutikken", Street = "Hovedgaden", Mail = "is@mail.com", Phone = "123456789", Zipcode = "9000", City = "Storeby", Status = true });
            //MyCustomers.Add(new Customer() {CustomerID = 22, Name = "Skoshop", Street = "Hovedgaden", Mail = "sko@mail.com", Phone = "123456789", Zipcode = "2000", City = "Mellemby", Status = false });
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
                ((App)App.Current).ContentControlRef.Content = new EditCustomerView();
            });

        public ICommand DeactivateCustomerCmd => new CustomerCommand(
            () =>
            {
                ((App)App.Current).ContentControlRef.Content = new DeleteCustomerView();
            });

        public ICommand SaveCmd => new CustomerCommand(
            () =>
            {
                ((App)App.Current).ContentControlRef.Content = new WelcomeMenuView();
            });

        public ICommand CancelCmd => new CustomerCommand(
            () =>
            {
                ((App)App.Current).ContentControlRef.Content = new WelcomeMenuView();
            });

        public ICommand SendCmd => new CustomerCommand(
            () =>
            {
                ((App)App.Current).ContentControlRef.Content = new WelcomeMenuView();
            });

        public ICommand DeactivateCmd => new CustomerCommand(
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

