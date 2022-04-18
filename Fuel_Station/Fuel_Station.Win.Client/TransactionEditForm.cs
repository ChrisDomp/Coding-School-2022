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

        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;
        private readonly State _state;
        private Transaction _itemToEdit;
        public List<TransactionLineListViewModel> transactionLineList = new List<TransactionLineListViewModel>();
        public List<EmployeeListViewModel> employeeList = new List<EmployeeListViewModel>();
        public Transaction transaction;

        public TransactionEditForm(Transaction transaction, IEntityRepo<Transaction> transactionRepo, List<EmployeeListViewModel> employeeList, IEntityRepo<TransactionLine> transactionLineRepo, State state, Transaction itemToEdit)
        {
            InitializeComponent();

            this.transaction = transaction;
            _transactionRepo = transactionRepo;
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

            //if (_state == State.Edit)
            //{
              
            //}
            comboPayMethod.DataSource = Enum.GetValues(typeof(PaymentMethod));
            comboEmployee.DataSource = employeeList;
            comboEmployee.DisplayMember = "Surname";
            comboEmployee.ValueMember = "Id";

           
        }


        private void CalcTotalValue()
        {
            transaction.TotalValue = 0;
            for (var i = 0; i < GVTransactionLines.Rows.Count; i++)            
                transaction.TotalValue += (decimal)GVTransactionLines.Rows[i].Cells[8].Value;
        }

        private async Task LoadDataFromServerAsync()
        {
            var client = new HttpClient();
            transactionLineList = await client.GetFromJsonAsync<List<TransactionLineListViewModel>>("https://localhost:7203/TransactionLines");
   
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new TransactionLineForm(transaction, _transactionLineRepo, State.New);
            form.ShowDialog();
            LoadDataFromServerAsync();
            //CalcTotalValue();
           
        }

        private void PopulateGrid()
        {
            GVTransactionLines.DataSource = null;
            GVTransactionLines.DataSource = transactionLineList.Where(tr => tr.TransactionID == transaction.ID).ToList();
            GVTransactionLines.Columns[0].Visible = false;
            GVTransactionLines.Columns[1].Visible = false;
            //GVTransactionLines.Columns[2].Visible = false;

            GVTransactionLines.Refresh();
            GVTransactionLines.Update();
            CalcTotalValue(); 
            txtTotalValue.EditValue = transaction.TotalValue.ToString();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
            //PopulateControls();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            transaction.EmployeeID = (Guid)comboEmployee.SelectedValue;
            transaction.PaymentMethod = (PaymentMethod)Enum.Parse(typeof(PaymentMethod),comboPayMethod.SelectedValue.ToString());
          
            
            _transactionRepo.UpdateAsync(transaction.ID, transaction);
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Do you want to delete the selected item ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                return;
            var itemToDeleteId = (Guid)GVTransactionLines.SelectedRows[0].Cells[0].Value;
            _transactionLineRepo.DeleteAsync(itemToDeleteId);
            LoadDataFromServerAsync();
            PopulateGrid();
        }
       
    }
}