namespace Fuel_Station.Win.Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void editCustomersToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form form = new CustomerForm();
            form.ShowDialog();

        }

        private void editItemsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = new ItemForm();
            form.ShowDialog();
        }

        private void editTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new TransactionForm();
            form.ShowDialog();
        }
    }
}