using System;
using System.Collections.Generic;
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
        public HttpClient client { get; set; } = new HttpClient();
        public Customer customer { get; set; }
       
        
        
        public async void getCustomers()
        {
            //setting the base address
            client.BaseAddress = new Uri("https://localhost:44390/");
            //adding an accept header for JSON format
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //sending HHTP request
            HttpResponseMessage response = await client.GetAsync("https://localhost:44390/api/Customers");
            response.EnsureSuccessStatusCode();
            var resp = await response.Content.ReadAsStringAsync();

            Console.WriteLine(resp);
            Console.ReadLine();

        }

        public void AddCustomer()
        {
            client.BaseAddress = new Uri("http://localhost:44390/");
            //adding an accept header for JSON format
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var customer = new Customer();
            
        }
        
    }
}
