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
            GVItems.DataSource = itemList;
            GVItems.Refresh();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //var editForm = new ItemEditForm(_itemRepo, State.New);
            //editForm.ShowDialog();
            LoadItemsFromServer();
        }
    }
}


