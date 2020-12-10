using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfIdeaAdmin.Model
{
    public class SingletonSharedData
    {
        private SingletonSharedData()
        {
            
        }

        private static SingletonSharedData sharedData;
        public Customer SelectedCustomer { get; set; }

        public static SingletonSharedData getInstance()
        {
            if(sharedData == null)
            {
                sharedData = new SingletonSharedData();
            }
            return sharedData;
        }
    }
}
