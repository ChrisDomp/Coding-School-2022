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

    }
}
