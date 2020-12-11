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
    public class WelcomeMenuViewModel : Bindable
    {
        public SingletonSharedData singleSharedData { get; set; }
        private ObservableCollection<Customer> myCutomerList;
        public ObservableCollection<Customer> MyCustomerList { get { return myCutomerList; } set { myCutomerList = value; this.propertyIsChanged(); } }
        
        public Model.ApiHelper apiHelperSingleton { get; set; }
        public Customer NewCustomer { get; set; }


        public WelcomeMenuViewModel()
        {
            singleSharedData = SingletonSharedData.getInstance();
            NewCustomer = new Customer();
            
            NewCustomer.CustomerName = "testName";
            apiHelperSingleton = new ApiHelper();
            //calling the getCustomers() method in the ApiHelper class to get Customers from DB
            MyCustomerList = apiHelperSingleton.getCustomers();
        }
        

        public ICommand AddCustomerCmd => new CustomerCommand(
            () =>
            {
                ((App)App.Current).ContentControlRef.Content = new AddCustomerView();
            });


        public ICommand CreateURLCmd => new CustomerCommand(
            () =>
            {
                //(Console.WriteLine("SelectedCustomer fra welcome: " + singleSharedData.SelectedCustomer.CustomerName);
                //Console.WriteLine("SelctedCustomer: " + SingletonSharedData.getInstance().SelectedCustomer.CustomerName);
                //Customer SelectedCustomer = new Customer(); //test
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
    }
}
