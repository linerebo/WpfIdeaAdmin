using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfIdeaAdmin.Model;

namespace WpfIdeaAdmin.View

{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            this.DataContext = ((App)App.Current).viewmodel;

            //store current window in public variable ContentControlRef
            ((App)App.Current).ContentControlRef = this.mainContent;
            this.mainContent.Content = new WelcomeMenuView();
            ApiHelper testAPI = new ApiHelper();
            testAPI.getCustomers();
            
        }
    }
}
