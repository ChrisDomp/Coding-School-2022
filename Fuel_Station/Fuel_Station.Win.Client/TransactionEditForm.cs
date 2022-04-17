using Fuel_Station.Blazor.Shared;
using Fuel_Station.EF.Repositories;
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
    public partial class TransactionEditForm : Form
    {
        private readonly CustomerListViewModel _customer;
        //private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;
        private readonly State _state;
        private Transaction _itemToEdit;
        public List<TransactionLineListViewModel> transactionLineList = new List<TransactionLineListViewModel>();
        public List<EmployeeListViewModel> employeeList = new List<EmployeeListViewModel>();
        public List<ItemListViewModel> itemList = new List<ItemListViewModel>();
        public TransactionEditForm(CustomerListViewModel customer, List<EmployeeListViewModel> employeeList,IEntityRepo<TransactionLine> transactionLineRepo,State state,Transaction itemToEdit)
        {
            InitializeComponent();
            _customer = customer;
            _transactionLineRepo = transactionLineRepo;
            _state = state;
            _itemToEdit = itemToEdit;
            this.employeeList = employeeList;

        }

        private void TransactionEditForm_Load(object sender, EventArgs e)
        {
            //LoadItemsFromServer();
            PopulateControls();
        }

        private void PopulateControls()
        {
            
            if (_state == State.Edit)
            {
                //txtDescription.Text = _itemToEdit.Description;
                //spinEditCost.Value = _itemToEdit.Cost;
                //spinEditPrice.Value = _itemToEdit.Price;
                //comboType.Text = _itemToEdit.ItemType.ToString();
            }
            comboPayMethod.DataSource = Enum.GetValues(typeof(PaymentMethod));
            comboEmployee.DataSource = employeeList;
            comboEmployee.DisplayMember = "Surname";
            comboEmployee.ValueMember = "Id";



        }

        private async Task LoadItemsFromServer()
        {
            var client = new HttpClient();
            itemList = await client.GetFromJsonAsync<List<ItemListViewModel>>("https://localhost:7203/Item");

         
            //var dummyEmployee = new EmployeeListViewModel()
            //{
            //    Name = "xs",
            //    Surname = "ss",
            //    SalaryPerMonth = 0,

            //};
            //employeeList.Add(dummyEmployee);
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoadItemsFromServer();
            var form = new TransactionLineForm(itemList,State.New);
            form.ShowDialog();
        }
    }
}
