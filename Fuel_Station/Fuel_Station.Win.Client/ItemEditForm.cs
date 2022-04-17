using Fuel_Station.EF.Repositories;
using Fuel_Station.Model;
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
  
    public partial class ItemEditForm : Form
    {
        private readonly IEntityRepo<Item> _itemRepo;
        private readonly State _state;
        private Item _itemToEdit;
        public ItemEditForm(IEntityRepo<Item> itemRepo,State state, Item itemToEdit)
        {
            InitializeComponent();
            _itemRepo = itemRepo;
            _state = state; 
            _itemToEdit = itemToEdit;
            PopulateControls();
       }

        private void PopulateControls()
        {

            if (_state == State.Edit)
            {
                txtDescription.Text = _itemToEdit.Description;
                spinEditCost.Value = _itemToEdit.Cost;
                spinEditPrice.Value = _itemToEdit.Price;
                comboType.Text = _itemToEdit.ItemType.ToString();
            }
            comboType.DataSource = Enum.GetValues(typeof(ItemType));
        }

        public ItemEditForm(IEntityRepo<Item> itemRepo, State state)
        {
            InitializeComponent();
            _itemRepo = itemRepo;
            _state = state;
            PopulateControls();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (spinEditCost.Value < 0 ||
            spinEditPrice.Value < 0) return;

            if (_state == State.New)
            {
                if (string.IsNullOrEmpty(txtDescription.Text))
                    return;
                var newItem = new Item()
                {
                    Description = txtDescription.Text,
                    ItemType = 0,
                    Cost = spinEditCost.Value,
                    Price = spinEditPrice.Value,
                };
                _itemRepo.CreateAsync(newItem);

            }
            if (_state == State.Edit)
            {
                _itemToEdit.Description = txtDescription.Text;
                _itemToEdit.Cost = spinEditCost.Value;
                _itemToEdit.Price = spinEditPrice.Value;
                _itemRepo.UpdateAsync(_itemToEdit.ID, _itemToEdit);
            }
            this.Close();

        }
    }
}
