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
    public partial class CashierForm : Form
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Item> _itemRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public CashierForm()
        {
            InitializeComponent();
        }

        public CashierForm(IEntityRepo<Customer> customerRepo, IEntityRepo<TransactionLine> transactionLineRepo, IEntityRepo<Transaction> transactionRepo)
        {
            InitializeComponent();
            _customerRepo = customerRepo;
          
            _transactionLineRepo = transactionLineRepo;
            _transactionRepo = transactionRepo;
        }

        private void editCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form form = new CustomerForm(_customerRepo);
            form.ShowDialog();
        }

        private void editTransactionStripMenuItem_Click(object sender, EventArgs e)
        {

            Form form = new FindCustomerForm(_customerRepo, _itemRepo, _employeeRepo, _transactionRepo, _transactionLineRepo);
            form.ShowDialog();
        }
    }
}
