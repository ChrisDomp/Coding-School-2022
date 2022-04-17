using Fuel_Station.Blazor.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Station.Win.Client
{
    public partial class TransactionLineForm : Form
    {
        public List<ItemListViewModel> itemList = new List<ItemListViewModel>();
        private readonly State _state;
        public TransactionLineForm(List<ItemListViewModel> itemList,State state)
        {
            InitializeComponent();
            this.itemList = itemList;
            _state = state;
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
            comboItem.DataSource = itemList;
            
            comboItem.DisplayMember = "Description";
            comboItem.ValueMember = "Id";

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
            totalValue = GetDiscountValue() - GetDiscount();
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
            var netValue = ((decimal)(spinEdit1.EditValue)) * itemList[comboItem.SelectedIndex].Price;
            return netValue;
        }

        private decimal GetDiscount()
        {
            decimal discount = 0;
            if (itemList[comboItem.SelectedIndex].ItemType == Model.ItemType.Fuel&& GetNetValue()>20)
            {
                discount = (decimal) 0.1 ;
            }
            return discount;

        }
    }
}
