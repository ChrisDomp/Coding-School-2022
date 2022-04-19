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
    public partial class StaffForm : Form
    {
        private readonly IEntityRepo<Item> _itemRepo;
        public StaffForm(IEntityRepo<Item> itemRepo)
        {
            InitializeComponent();
            _itemRepo = itemRepo;
        }

        private void editItemsStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = new ItemForm(_itemRepo);
            form.ShowDialog();
        }
    }
}
