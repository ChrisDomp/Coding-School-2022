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
        //private readonly IEntityRepo<Item> _itemRepo;
        //private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;
        public List<TransactionListViewModel> transactionList = new List<TransactionListViewModel>();
        public List<TransactionListViewModel> customerTransactions = new List<TransactionListViewModel>();
        public List<EmployeeListViewModel> employeeList = new List<EmployeeListViewModel>();


        public TransactionForm(CustomerListViewModel foundCustomer, IEntityRepo<Item> itemRepo, IEntityRepo<Employee> employeeRepo, IEntityRepo<Transaction> transactionRepo, IEntityRepo<TransactionLine> transactionLineRepo)
        {
            InitializeComponent();
            _customer = foundCustomer;
            //_itemRepo = itemRepo;
            //_employeeRepo = employeeRepo;
            _transactionRepo = transactionRepo;
            _transactionLineRepo = transactionLineRepo;
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            LoadItemsFromServerAsync();

        }
        private async Task LoadItemsFromServerAsync()
        {
            var client = new HttpClient();
            transactionList = await client.GetFromJsonAsync<List<TransactionListViewModel>>("https://localhost:7203/transaction");
            customerTransactions = transactionList.FindAll(transaction => transaction.CustomerID == _customer.Id).ToList();
            client = new HttpClient();
            employeeList = await client.GetFromJsonAsync<List<EmployeeListViewModel>>("https://localhost:7203/Employee");

            GVTransactions.DataSource = customerTransactions;
            GVTransactions.Refresh();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var transactionEditForm = new TransactionEditForm(_customer,employeeList,_transactionLineRepo,State.New,null);
            transactionEditForm.ShowDialog();
            LoadItemsFromServerAsync();

        }
    }
}
