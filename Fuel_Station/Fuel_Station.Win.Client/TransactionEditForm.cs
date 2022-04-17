using Fuel_Station.Blazor.Shared;
using Fuel_Station.EF.Repositories;
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
    public partial class TransactionEditForm : Form
    {
        private readonly CustomerListViewModel _customer;
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;
        private readonly State _state;
        public List<TransactionListViewModel> transactionList = new List<TransactionListViewModel>();
        public List<TransactionListViewModel> customerTransactions = new List<TransactionListViewModel>();
        public TransactionEditForm(CustomerListViewModel customer,IEntityRepo<Transaction> transactionRepo,IEntityRepo<TransactionLine> transactionLineRepo,State state)
        {
            InitializeComponent();
            _customer = customer;
            _transactionRepo = transactionRepo;
            _transactionLineRepo = transactionLineRepo;
            _state = state;
        }
    }
}
