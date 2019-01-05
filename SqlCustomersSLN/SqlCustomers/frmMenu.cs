using System;
using System.Windows.Forms;

namespace SqlCustomers
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnViewAudit_Click(object sender, EventArgs e)
        {
            frmAuditData frmAuditData1 = new frmAuditData();
            Hide();
            frmAuditData1.ShowDialog();
            Show();
        }

        private void btnAddCustomers_Click(object sender, EventArgs e)
        {
            frmAddCustomers frmAddCustomers1 = new frmAddCustomers();
            Hide();
            frmAddCustomers1.ShowDialog();
            Show();
        }

        private void btnUpdateDelete_Click(object sender, EventArgs e)
        {
            frmUpdateDelete frmUpdateDelete1 = new frmUpdateDelete();
            Hide();
            frmUpdateDelete1.ShowDialog();
            Show();
        }
    }
}
