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
    public partial class CustomerForm : Form
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        public List<CustomerListViewModel> customerList= new List<CustomerListViewModel>();
        public CustomerForm(IEntityRepo<Customer> customerRepo)
        {
            InitializeComponent();
            _customerRepo = customerRepo;
        }



        private void CustomersForm_Load(object sender, EventArgs e)
        {
            LoadItemsFromServer();
        }

        private async Task LoadItemsFromServer()
        {
            GVCustomers.DataSource = null;
            var client = new HttpClient();
            customerList = await client.GetFromJsonAsync<List<CustomerListViewModel>>("https://localhost:7203/customer");
            GVCustomers.DataSource = customerList;
            GVCustomers.Refresh();
            GVCustomers.Update();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var editForm = new CustomerEditForm(_customerRepo,State.New);
            editForm.ShowDialog();
            LoadItemsFromServer();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Do you want to delete the selected item ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                return;
            var itemToDeleteId = (Guid)GVCustomers.SelectedRows[0].Cells[0].Value;
            _customerRepo.DeleteAsync(itemToDeleteId);
            LoadItemsFromServer();
        }

      

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var itemToEditId = (Guid)GVCustomers.SelectedRows[0].Cells[0].Value;
            var itemToEdit = new Customer()
            {
                ID = itemToEditId,
                Name = (string)GVCustomers.SelectedRows[0].Cells[1].Value,
                Surname = (string)GVCustomers.SelectedRows[0].Cells[2].Value,
                CardNumber = (string)GVCustomers.SelectedRows[0].Cells[3].Value,

            };
            var editForm = new CustomerEditForm(_customerRepo,State.Edit, itemToEdit);
            editForm.ShowDialog();
            LoadItemsFromServer();
      }
    }
}
