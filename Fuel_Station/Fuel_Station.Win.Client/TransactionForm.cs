using Fuel_Station.Blazor.Shared;
using Fuel_Station.EF.Repositories;
using Fuel_Station.Model;
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
    public partial class TransactionForm : Form
    {
        private readonly CustomerListViewModel _customer;
        private readonly IEntityRepo<Item> _itemRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        public List<TransactionListViewModel> transactionList = new List<TransactionListViewModel>();


        public TransactionForm(CustomerListViewModel foundCustomer, IEntityRepo<Item> itemRepo, IEntityRepo<Employee> employeeRepo)
        {
            InitializeComponent();
            _customer = foundCustomer;
            _itemRepo = itemRepo;
            _employeeRepo = employeeRepo;

        }
        private async Task LoadItemsFromServerAsync()
        {
            var client = new HttpClient();
            transactionList = await client.GetFromJsonAsync<List<TransactionListViewModel>>("https://localhost:7203/transaction");
        }
    }
}
