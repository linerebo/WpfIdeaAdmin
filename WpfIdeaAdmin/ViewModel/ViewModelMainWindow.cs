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
        public ViewModelMainWindow()
        {
            ((App)App.Current).ContentControlRef.Content = new WelcomeMenuView();
        }

    }
}
