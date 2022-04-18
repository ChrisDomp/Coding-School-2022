using Fuel_Station.EF.Repositories;
using Fuel_Station.EF.Repository;
using Fuel_Station.Model;

namespace Fuel_Station.Win.Client
{
    public partial class MainForm : Form
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Item> _itemRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(IEntityRepo<Customer> customerRepo, IEntityRepo<Item> itemRepo, IEntityRepo<TransactionLine> transactionLineRepo, IEntityRepo<Transaction> transactionRepo)
        {
            InitializeComponent();
            _customerRepo = customerRepo;
            _itemRepo = itemRepo;
            _transactionLineRepo = transactionLineRepo;
            _transactionRepo = transactionRepo;
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
            Form form = new FindCustomerForm(_customerRepo,_itemRepo,_employeeRepo,_transactionRepo,_transactionLineRepo);
            form.ShowDialog();
        }
    }
}