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
    public class AdministratorViewModel : Bindable
    {
        private ObservableCollection<Customer> myCutomerList;
        public ObservableCollection<Customer> MyCustomerList { get { return myCutomerList; } set { myCutomerList = value; this.propertyIsChanged(); } }
        //public Customer SelectedCustomer { get; set; }
        public Model.ApiHelper apiHelperSingleton { get; set; }
        public Customer NewCustomer { get; set; }
        
        public AdministratorViewModel()
        {
            NewCustomer = new Customer();
            NewCustomer.CustomerName = "testName";
            apiHelperSingleton = new ApiHelper();
            //calling the getCustomers() method in the ApiHelper class to get Customers from DB
            //Task gcTask = apiHelperSingleton.getCustomers();
            
            ////waiting for the task to be completed
            //gcTask.Wait();
            //MyCustomerList = apiHelperSingleton.CustomerList;

            
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
            async() =>
            {
                //check if name is added mm
                //Task addTask = apiHelperSingleton.AddCustomer(NewCustomer);
                //addTask.Wait();
                ((App)App.Current).ContentControlRef.Content = new WelcomeMenuView();
                MyCustomerList = apiHelperSingleton.getCustomers();

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

