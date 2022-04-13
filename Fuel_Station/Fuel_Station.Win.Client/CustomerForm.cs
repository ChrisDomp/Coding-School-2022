using Fuel_Station.Blazor.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Station.Win.Client
{
    public partial class CustomerForm : Form
    {

        public List<CustomerListViewModel> customerList= new List<CustomerListViewModel>();
        public CustomerForm()
        {
            InitializeComponent();
        }



        private void CustomersForm_Load(object sender, EventArgs e)
        {
            LoadItemsFromServer();
            
        }

        private async Task LoadItemsFromServer()
        {
               var client = new HttpClient();
               customerList = await client.GetFromJsonAsync<List<CustomerListViewModel>>("https://localhost:7203/customer");
               grdCustomers.DataSource = customerList;
        }


    }
}
