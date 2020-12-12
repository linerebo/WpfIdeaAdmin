using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfIdeaAdmin.View;

namespace WpfIdeaAdmin.Model
{
    public class ApiHelper
    {
        private HttpClient client;
        public SingletonSharedData singleSharedData { get; set; }
        public Customer customer { get; set; }
        public ObservableCollection<Customer> CustomerList { get; set; } = new ObservableCollection<Customer>();
        //public Customer SelectedCustomer { get; set; }

        public ApiHelper()
        {
            singleSharedData = SingletonSharedData.getInstance();
        }

        //get customers as json string from db/api and convert to Customer objects
        public ObservableCollection<Customer> getCustomers()
        {
            client = new HttpClient();
            //setting the base address
            client.BaseAddress = new Uri("https://localhost:44390/");
            //adding an accept header for JSON format
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //sending HHTP request
            HttpResponseMessage response =  client.GetAsync("https://localhost:44390/api/Customers").Result;
            response.EnsureSuccessStatusCode();
            var resp =  response.Content.ReadAsStringAsync().Result;
            //converting json string to customer objects
            return JsonConvert.DeserializeObject<ObservableCollection<Customer>>(resp);
        }

        //method for adding new customer and post the json string to api/db
        public void AddCustomer(Customer NewCustomer)
        {
            Console.WriteLine("new customer zip: " + NewCustomer.Zip); // JC deleted ZipCode in between
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:44390/");
            //adding an accept header for JSON format
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string json = JsonConvert.SerializeObject(NewCustomer);
            var stringContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            Console.WriteLine("json " +json);
            HttpResponseMessage response = client.PostAsync("https://localhost:44390/api/Customers", stringContent).Result;
            response.EnsureSuccessStatusCode();
            var resp = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine("resp: " + resp);
        }
    }
}
