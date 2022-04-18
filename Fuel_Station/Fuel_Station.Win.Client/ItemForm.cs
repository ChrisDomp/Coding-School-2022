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
    public partial class ItemForm : Form
    {
        public List<ItemListViewModel> itemList = new List<ItemListViewModel>();
        private readonly IEntityRepo<Item> _itemRepo;


        public ItemForm(IEntityRepo<Item> itemRepo)
        {
            InitializeComponent();
            _itemRepo = itemRepo;
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            LoadItemsFromServer();
        }

        private async Task LoadItemsFromServer()
        {
            GVItems.DataSource = null;
            var client = new HttpClient();
            itemList = await client.GetFromJsonAsync<List<ItemListViewModel>>("https://localhost:7203/item");

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var ItemEditForm = new ItemEditForm(_itemRepo, State.New);
            ItemEditForm.ShowDialog();
            LoadItemsFromServer();
            PopulateGrid();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            var itemToEditId = (Guid)GVItems.SelectedRows[0].Cells[0].Value;
            var itemToEdit = new Item()
            {
                ID = itemToEditId,
                Code = (string)GVItems.SelectedRows[0].Cells[1].Value,
                Description = (string)GVItems.SelectedRows[0].Cells[2].Value,
                ItemType = (ItemType)GVItems.SelectedRows[0].Cells[3].Value,
                Price = (decimal)GVItems.SelectedRows[0].Cells[4].Value,
                Cost = (decimal)GVItems.SelectedRows[0].Cells[5].Value,

            };
            var editForm = new ItemEditForm(_itemRepo, State.Edit, itemToEdit);
            editForm.ShowDialog();
            LoadItemsFromServer();
            PopulateGrid();

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Do you want to delete the selected item ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                return;
            var itemToDeleteId = (Guid)GVItems.SelectedRows[0].Cells[0].Value;
            _itemRepo.DeleteAsync(itemToDeleteId);
            LoadItemsFromServer();
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            GVItems.DataSource = null;
            GVItems.DataSource = itemList;
            GVItems.Refresh();
            GVItems.Update();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}


