using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfIdeaAdmin.Model
{
    public class ZipCode : Bindable
    {
        private string _zipCode;
        public string Zip
        {
            get { return _zipCode; }
            set { _zipCode = value; this.propertyIsChanged(); }
        }

        private string _zipCodeCity;
        public string ZipCodeCity
        {
            get { return _zipCodeCity; }
            set { _zipCodeCity = value; this.propertyIsChanged(); }
        }
    }
}
