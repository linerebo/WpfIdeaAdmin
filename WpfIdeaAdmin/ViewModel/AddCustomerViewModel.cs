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
        private bool _showLabelName;
        public bool ShowLabelName { get { return _showLabelName; } set { _showLabelName = value; this.propertyIsChanged(); } }
        private bool _showLabelMail;
        public bool ShowLabelMail { get { return _showLabelMail; } set { _showLabelMail = value; this.propertyIsChanged(); } }


        public AddCustomerViewModel() 
        {
            singleSharedData = SingletonSharedData.getInstance();
            apiHelperSingleton = new ApiHelper();
            NewCustomer = new Customer();
            ShowLabelName = false;
            ShowLabelMail = false;
        }

        

        public ICommand SaveCmd => new CustomerCommand(
            async () =>
            {
                //input validation, check if CustomerName is null
                if (NewCustomer.CustomerName == null) 
                {
                    ShowLabelName = true;
                }
                //input validation, check if CustomerMail is null
                else if(NewCustomer.CustomerMail == null)
                {
                    ShowLabelMail = true;
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
