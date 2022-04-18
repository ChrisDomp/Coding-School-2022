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
            public TransactionListViewModel dummyTransaction = new TransactionListViewModel();
        private EmployeeListViewModel dummyEmployee;
        private Transaction newTransaction;

        public TransactionForm(CustomerListViewModel foundCustomer,IEntityRepo<Transaction> transactionRepo, IEntityRepo<TransactionLine> transactionLineRepo)
        {
            InitializeComponent();
            _customer = foundCustomer;
 
            _transactionRepo = transactionRepo;
            _transactionLineRepo = transactionLineRepo;
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            LoadItemsFromServerAsync();
            GetDummyEmployeeAsync();

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
            StoreDummyTransaction(dummyTransaction);
            var transactionEditForm = new TransactionEditForm(newTransaction,employeeList,_transactionLineRepo,State.New,null);
            transactionEditForm.ShowDialog();
            LoadItemsFromServerAsync();

        }
        private void StoreDummyTransaction(TransactionListViewModel transactionView)
        {
            
            
            newTransaction = new Transaction()
            {
                ID = transactionView.Id,
                Date = transactionView.Date,
                EmployeeID = dummyEmployee.Id,
                CustomerID = _customer.Id,
                PaymentMethod = transactionView.PaymentMethod,
                TotalValue = transactionView.TotalValue,


            };
            
            _transactionRepo.CreateAsync(newTransaction);
        }

        private async Task GetDummyEmployeeAsync()
        {
            var client = new HttpClient();
            var employeeList = new List<EmployeeListViewModel>();
            employeeList = await client.GetFromJsonAsync<List<EmployeeListViewModel>>("https://localhost:7203/Employee");
            dummyEmployee = employeeList[0];
        }
    }
}
