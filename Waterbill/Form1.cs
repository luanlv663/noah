namespace Water_Bills
{
    public partial class Form1 : Form
    {
        public ManageInvoices FormListInvoices = new ManageInvoices();
        public Form1()
        {
            InitializeComponent();

            addInvoiceUserControl.Hide();
            manageinvoicesUsercontrol.Hide();

            addInvoiceUserControl.ListInvoices = FormListInvoices;
            manageinvoicesUsercontrol.ListInvoices =  FormListInvoices;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddInvoiceMenuButton_Click(object sender, EventArgs e)
        {
            addInvoiceUserControl.Show();
            manageinvoicesUsercontrol.Hide();
            AddInvoiceMenuButton.BackColor = Color.DarkGray;
            AddInvoiceMenuButton.ForeColor = Color.White;

            ManageInvoicesMenuButton.BackColor = Color.White;
            ManageInvoicesMenuButton.ForeColor = Color.Black;
        }

        private void ManageInvoicesMenuButton_Click(object sender, EventArgs e)
        {
            addInvoiceUserControl.Hide();
            manageinvoicesUsercontrol.RefreshInvoiceList();
            manageinvoicesUsercontrol.Show();

            AddInvoiceMenuButton.BackColor = Color.White;
            AddInvoiceMenuButton.ForeColor = Color.Black;

            ManageInvoicesMenuButton.BackColor = Color.DarkGray;
            ManageInvoicesMenuButton.ForeColor = Color.White;
        }
    }
}
