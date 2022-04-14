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
    public partial class CustomerEditForm : Form
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly State _state;
        private Customer _itemToEdit;
        public CustomerEditForm(IEntityRepo<Customer> customerRepo,State state)
        {
            InitializeComponent();
            _customerRepo = customerRepo;
            _state = state;
        }
        public CustomerEditForm(IEntityRepo<Customer> customerRepo, State state,Customer entity)
        {
            InitializeComponent();
            _customerRepo = customerRepo;
            _state = state;
            _itemToEdit = entity;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_state == State.New)
            {
                if (string.IsNullOrEmpty(textName.Text) || String.IsNullOrEmpty(txtSurname.Text))
                    return;
                var newCustomer = new Customer()
                {
                    Name = textName.Text,
                    Surname = txtSurname.Text,
                };
                _customerRepo.CreateAsync(newCustomer);

            }
            if(_state == State.Edit)
            {
                _itemToEdit.Name = textName.Text;
                _itemToEdit.Surname = txtSurname.Text;
                _customerRepo.UpdateAsync(_itemToEdit.ID, _itemToEdit);
            }
            this.Close();

        }


    }
}
