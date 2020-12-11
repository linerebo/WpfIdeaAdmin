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
    public class AddCustomerViewModel : Bindable
    {
        public SingletonSharedData singleSharedData { get; set; }
        private ObservableCollection<Customer> myCutomerList;
        public ObservableCollection<Customer> MyCustomerList { get { return myCutomerList; } set { myCutomerList = value; this.propertyIsChanged(); } }
        public Model.ApiHelper apiHelperSingleton { get; set; }
        public Customer NewCustomer { get; set; }


        public AddCustomerViewModel()
        {
            singleSharedData = SingletonSharedData.getInstance();
            apiHelperSingleton = new ApiHelper();
            NewCustomer = new Customer();
        }

        public ICommand SaveCmd => new CustomerCommand(
            async () =>
            {
                //check if CustomerName is null
                if (NewCustomer.CustomerName == null) 
                {
                    Console.WriteLine("Indtast navn");  //change to messagebox or show text in NewCustomer.Name in View
                }
                else
                {
                    apiHelperSingleton.AddCustomer(NewCustomer);
                    ((App)App.Current).ContentControlRef.Content = new WelcomeMenuView();
                    MyCustomerList = apiHelperSingleton.getCustomers();
                }

            });

        public ICommand CancelCmd => new CustomerCommand(
            () =>
            {
                ((App)App.Current).ContentControlRef.Content = new WelcomeMenuView();
            });
    }
}
