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
    public partial class FindCustomerForm : Form
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Item> _itemRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;
        public List<CustomerListViewModel> customerList = new List<CustomerListViewModel>();
        private CustomerListViewModel? foundCustomer;
        private int foundCustomerIndex;


        public FindCustomerForm(IEntityRepo<Customer> customerRepo,IEntityRepo<Item> itemRepo,IEntityRepo<Employee> employeeRepo)
        {
            InitializeComponent();
            _customerRepo = customerRepo;
            _itemRepo = itemRepo;
            _employeeRepo = employeeRepo;
        }   
    private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtCardNumber.Text == String.Empty || txtCardNumber.Text[0] != 'A')
            {
                MessageBox.Show("Please enter a valid card number");
                return;
               
            }
            if (FindCustomer() == null)
            {
                var form1 = new CustomerEditForm(_customerRepo, State.New);
                form1.ShowDialog();
            }
            else
            {
                var form2 = new TransactionForm(foundCustomer, _itemRepo, _employeeRepo, _transactionRepo, _transactionLineRepo);
                form2.ShowDialog();
            }

        }

        private CustomerListViewModel? FindCustomer()
        {
           
            foundCustomerIndex = customerList.FindIndex(customer =>customer.CardNumber == txtCardNumber.Text);
            if (foundCustomerIndex == -1) return null;
            foundCustomer = customerList[foundCustomerIndex];
            return foundCustomer;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindCustomerForm_Load(object sender, EventArgs e)
        {
            LoadItemsFromServerAsync();
            
        }

        private async Task LoadItemsFromServerAsync()
        {
            var client = new HttpClient();
            customerList = await client.GetFromJsonAsync<List<CustomerListViewModel>>("https://localhost:7203/customer");
        }
    }
}
