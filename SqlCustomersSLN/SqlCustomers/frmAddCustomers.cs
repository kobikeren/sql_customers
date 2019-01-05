using SqlCustomersBLL;
using System;
using System.Windows.Forms;

namespace SqlCustomers
{
    public partial class frmAddCustomers : Form
    {
        //create a business-logic manager
        SqlCustomersBLManager blManager = new SqlCustomersBLManager();

        public frmAddCustomers()
        {
            InitializeComponent();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnClearMessage_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void btnInsertCustomer_Click(object sender, EventArgs e)
        {
            //validate user input
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Please enter customer name", "Invalid Input");
                txtCustomerName.Focus();
                return;
            }

            string sumOfPurchasesMessage = "Please enter sum of purchases\n\n" +
                "sum of purchases must end with three zeros and be greater or equal to 1000\n" +
                "For example: 27000";
            string allNumbers = "1234567890";
            string allNumbersButZero = "123456789";
            bool sumOfPurchasesValid = true;

            if (txtSumOfPurchases.Text.Length < 4 ||
                txtSumOfPurchases.Text.Length > 10 ||
                !txtSumOfPurchases.Text.EndsWith("000"))
            {
                sumOfPurchasesValid = false;
            }

            for (int i = 0; i < txtSumOfPurchases.Text.Length; i++)
            {
                string underTest = txtSumOfPurchases.Text.Substring(i, 1);
                if (i == 0)
                {
                    if (allNumbersButZero.IndexOf(underTest) == -1)
                    {
                        sumOfPurchasesValid = false;
                    }
                }
                else
                {
                    if (allNumbers.IndexOf(underTest) == -1)
                    {
                        sumOfPurchasesValid = false;
                    }
                }
            }

            if (!sumOfPurchasesValid)
            {
                MessageBox.Show(sumOfPurchasesMessage, "Invalid Input");
                txtSumOfPurchases.Focus();
                txtSumOfPurchases.SelectAll();
                return;
            }

            if (txtCity.Text == "")
            {
                MessageBox.Show("Please enter city", "Invalid Input");
                txtCity.Focus();
                return;
            }

            if (txtTelephone.Text == "")
            {
                MessageBox.Show("Please enter telephone", "Invalid Input");
                txtTelephone.Focus();
                return;
            }

            if (txtAccountManager.Text == "")
            {
                MessageBox.Show("Please enter account manager", "Invalid Input");
                txtAccountManager.Focus();
                return;
            }

            if (txtCategory.Text == "")
            {
                MessageBox.Show("Please enter category", "Invalid Input");
                txtCategory.Focus();
                return;
            }

            //validation successful --> insert
            int newId;
            Customer customer = new Customer();
            customer.CustomerName = txtCustomerName.Text;
            customer.SumOfPurchases = int.Parse(txtSumOfPurchases.Text);
            customer.City = txtCity.Text;
            customer.Telephone = txtTelephone.Text;
            customer.AccountManager = txtAccountManager.Text;
            customer.Category = txtCategory.Text;

            blManager.InsertCustomer(customer, out newId);
            lblMessage.Text = "New customer Id = " + newId.ToString();

            ClearFields();
        }

        private void ClearFields()
        {
            txtCustomerName.Clear();
            txtSumOfPurchases.Clear();
            txtCity.Clear();
            txtTelephone.Clear();
            txtAccountManager.Clear();
            txtCategory.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
