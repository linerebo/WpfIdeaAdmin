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

        private int customerID;
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; this.propertyIsChanged(); }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set{ name = value; this.propertyIsChanged(); }
        }

        private string mail;
        public string Mail
        {
            get { return mail; }
            set { mail = value; this.propertyIsChanged(); }
        }

        private bool status;
        public bool Status
        {
            get { return status; }
            set { status = value; this.propertyIsChanged(); }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; this.propertyIsChanged(); }
        }

        private string street;
        public string Street
        {
            get { return street; }
            set { street = value; this.propertyIsChanged(); }
        }

        private string zipcode;
        public string Zipcode
        {
            get { return zipcode; }
            set { zipcode = value;  this.propertyIsChanged(); }
        }

        private string city;
        public string City
        {
            get { return city; }
            set { city = value; this.propertyIsChanged(); }
        }
    }
}
