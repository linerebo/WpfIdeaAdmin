using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfIdeaAdmin.Model
{
    public class Customer : Bindable
    {
        private List<Customer> _customers;
        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; this.propertyIsChanged(); }
        }

        private int _customerID;
        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; this.propertyIsChanged(); }
        }

        private string _customername;
        public string CustomerName
        {
            get { return _customername; }
            set{ _customername = value; this.propertyIsChanged(); }
        }

        private string _customerMail;
        public string CustomerMail
        {
            get { return _customerMail; }
            set { _customerMail = value; this.propertyIsChanged(); }
        }

        private bool _customerStatus;
        public bool CustomerStatus
        {
            get { return _customerStatus; }
            set { _customerStatus = value; this.propertyIsChanged(); }
        }

        private string _customerPhone;
        public string CustomerPhone
        {
            get { return _customerPhone; }
            set { _customerPhone = value; this.propertyIsChanged(); }
        }

        private string _customerStreet;
        public string CustomerStreet
        {
            get { return _customerStreet; }
            set { _customerStreet = value; this.propertyIsChanged(); }
        }

        private string _customerZip; // added by JC!!!
        public string Zip
        {
            get { return _customerZip; }
            set { _customerZip = value; this.propertyIsChanged(); }
        }


        private ZipCode _zipCode; // = new ZipCode(); outcomment by JC!!!
        public ZipCode ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; this.propertyIsChanged(); }
        }


    }
}
