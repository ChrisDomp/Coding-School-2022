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
    public partial class TransactionLineForm : Form
    {
        public List<ItemListViewModel> itemList = new List<ItemListViewModel>();
        private readonly State _state;
        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;
        private readonly List<TransactionLineListViewModel> _transactionLineList;
        public Transaction transaction;



        public TransactionLineForm(Transaction transaction, List<TransactionLineListViewModel> transactionLineList, IEntityRepo<TransactionLine> transactionLineRepo,State state)
        {
            InitializeComponent();
            _state = state;
            _transactionLineRepo = transactionLineRepo;
            _transactionLineList = transactionLineList.Where(tr => tr.TransactionID == transaction.ID).ToList();
            this.transaction = transaction;
            LoadItemsFromServerAsync();
            PopulateControls();
        }

        private async Task LoadItemsFromServerAsync()
        {
            var client = new HttpClient();
            itemList = await client.GetFromJsonAsync<List<ItemListViewModel>>("https://localhost:7203/Item");

        }

        private void PopulateControls()
        {
            if (FuelExists())
                comboItem.DataSource = itemList.Where(item => item.ItemType != ItemType.Fuel).ToList(); 
            else comboItem.DataSource = itemList;
            comboItem.DisplayMember = "Description";
            comboItem.ValueMember = "Id";

        }

        private bool FuelExists()
        {
            var itemToTest = new ItemListViewModel();
            foreach ( var line in _transactionLineList)
            {
                foreach(var item in itemList)
                {
                    itemToTest = itemList.Single(item =>item.Id == line.ItemID);
                    if (itemToTest.ItemType == ItemType.Fuel)
                        return true;
                }   
            }
            return false;
        }

        private void comboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice.EditValue = ((decimal)(spinEdit1.EditValue)) * itemList[comboItem.SelectedIndex].Price;

        }

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            GetNetValue();
            GetDiscount();
            GetDiscountValue();
            txtPrice.EditValue = GetNetValue();
            txtDiscountPercentage.EditValue = 100 * GetDiscount() ;
            txtDiscountValue.EditValue = GetDiscountValue();
            txtTotalValue.EditValue = GetTotalValue();

        }

        private decimal GetTotalValue()
        {   
            decimal totalValue = 0;
            totalValue = GetNetValue() - GetDiscountValue();
            return totalValue;
        }

        private decimal GetDiscountValue()
        {
            decimal discountValue = 0;
            discountValue = GetNetValue() * GetDiscount(); 

            return discountValue;
        }

        private decimal GetNetValue()
        {
            var Quantity = (decimal)spinEdit1.EditValue;
            var netValue = Quantity * (decimal)itemList[comboItem.SelectedIndex].Price;
            return netValue;
        }

        private decimal GetDiscount()
        {
            decimal discount = 0;
            if (itemList[comboItem.SelectedIndex].ItemType == Model.ItemType.Fuel&& GetNetValue() > 20)
            {
                discount = (decimal)0.1 ;
            }
            return discount;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var newTransactionLine = new TransactionLine()
            {
                TransactionID = transaction.ID,
                ItemID = itemList[comboItem.SelectedIndex].Id,
                Quantity = Convert.ToInt32(spinEdit1.EditValue),
                ItemPrice = itemList[comboItem.SelectedIndex].Price,
                NetValue = GetNetValue(),
                DiscountPercent = GetDiscount(),
                DiscountValue = GetDiscountValue(),
                TotalValue = GetTotalValue(),

            };
            _transactionLineRepo.CreateAsync(newTransactionLine);
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateControls();
        }
    }
}
