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
    public partial class AuthenicationForm : Form
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Item> _itemRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public AuthenicationForm(IEntityRepo<Customer> customerRepo, IEntityRepo<Item> itemRepo, IEntityRepo<TransactionLine> transactionLineRepo, IEntityRepo<Transaction> transactionRepo)
        {
            InitializeComponent();
            _customerRepo = customerRepo;
            _itemRepo = itemRepo;
            _transactionLineRepo = transactionLineRepo;
            _transactionRepo = transactionRepo;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ValidateCredentials(txtUsername.EditValue.ToString(),txtPassword.EditValue.ToString());
        }

        private void ValidateCredentials(string username, string password)
        {
            if (username == "Manager" && password == "Manager")
            {
                var form = new MainForm(_customerRepo, _itemRepo, _transactionLineRepo, _transactionRepo);
                form.Show();
               
            }
            else if (username == "Cashier" && password == "Cashier")
            {
                var form = new CashierForm(_customerRepo, _transactionLineRepo, _transactionRepo);
                form.Show();
            }
            else if(username =="Staff" && password == "Staff")
            {
                var form = new StaffForm(_itemRepo);
                form.Show();
            }
            else 
                MessageBox.Show("Wrong Credentials!");

        }
    }
}
