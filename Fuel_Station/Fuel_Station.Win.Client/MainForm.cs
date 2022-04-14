using Fuel_Station.EF.Repositories;
using Fuel_Station.EF.Repository;
using Fuel_Station.Model;

namespace Fuel_Station.Win.Client
{
    public partial class MainForm : Form
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Item> _itemRepo;

        public MainForm(IEntityRepo<Customer> customerRepo, IEntityRepo<Item> itemRepo)
        {
            InitializeComponent();
            _customerRepo = customerRepo;
            _itemRepo = itemRepo;
        }



        private void editCustomersToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form form = new CustomerForm( _customerRepo);
            form.ShowDialog();

        }

        private void editItemsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = new ItemForm(_itemRepo);
            form.ShowDialog();
        }

        private void editTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new TransactionForm();
            form.ShowDialog();
        }
    }
}