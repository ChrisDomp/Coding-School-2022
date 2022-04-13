using Fuel_Station.Blazor.Shared;
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


        public ItemForm()
        {
            InitializeComponent();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            LoadItemsFromServer();
        }

        private async Task LoadItemsFromServer()
        {
            var client = new HttpClient();
            itemList = await client.GetFromJsonAsync<List<ItemListViewModel>>("https://localhost:7203/item");
            grdItems.DataSource = itemList;
        }

    }
}


