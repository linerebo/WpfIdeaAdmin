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
        public SingletonSharedData singleSharedData { get; set; }
        public Model.ApiHelper apiHelperSingleton { get; set; }
        

        public CreateUrlViewModel()
        {
            singleSharedData = SingletonSharedData.getInstance();
            apiHelperSingleton = new ApiHelper();
            
        }
         
        public ICommand SendCmd => new CustomerCommand(
            () =>
            {
                ((App)App.Current).ContentControlRef.Content = new WelcomeMenuView();
            });

        public ICommand CancelCmd => new CustomerCommand(
            () =>
            {
                ((App)App.Current).ContentControlRef.Content = new WelcomeMenuView();
            });
    }
}
