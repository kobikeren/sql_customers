using SqlCustomersBLL;
using System;
using System.Windows.Forms;

namespace SqlCustomers
{
    public partial class frmUpdateDelete : Form
    {
        //create a business-logic manager
        SqlCustomersBLManager blManager = new SqlCustomersBLManager();

        public frmUpdateDelete()
        {
            InitializeComponent();
        }

        private void btnRetrieveCustomer_Click(object sender, EventArgs e)
        {
            bool customerIdIsValid = true;
            string allNumbers = "1234567890";

            //validate user input
            if (txtCustomerId.Text == "" || txtCustomerId.Text.Length > 7)
            {
                customerIdIsValid = false;
            }

            //validate user input
            for (int i = 0; i < txtCustomerId.Text.Length; i++)
            {
                string underTest = txtCustomerId.Text.Substring(i, 1);

                if (allNumbers.IndexOf(underTest) == -1)
                {
                    customerIdIsValid = false;
                }
            }

            //validation failed: display a message
            if (!customerIdIsValid)
            {
                MessageBox.Show("Please enter a valid customer Id", "Invalid Input");
                txtCustomerId.Focus();
                txtCustomerId.SelectAll();
                return;
            }

            //validation successful: try to retrieve customer
            Customer customer = blManager.GetCustomerById(int.Parse(txtCustomerId.Text));
            
            //customer id was not found in the DB
            if (customer.Id == 0)
            {
                MessageBox.Show("customer Id = " + txtCustomerId.Text +
                    " was not found", "Message");
                txtCustomerId.Focus();
                txtCustomerId.SelectAll();
                return;
            }

            //customer id found in the DB
            lblCustomerIdForUpdate.Text = customer.Id.ToString();
            txtCustomerName.Text = customer.CustomerName;
            txtSumOfPurchases.Text = customer.SumOfPurchases.ToString();
            txtCity.Text = customer.City;
            txtTelephone.Text = customer.Telephone;
            txtAccountManager.Text = customer.AccountManager;
            txtCategory.Text = customer.Category;

            lblCustomerIdForDelete.Text = customer.Id.ToString();
            lblCustomerName.Text = customer.CustomerName;
            lblSumOfPurchases.Text = customer.SumOfPurchases.ToString();
            lblCity.Text = customer.City;
            lblTelephone.Text = customer.Telephone;
            lblAccountManager.Text = customer.AccountManager;
            lblCategory.Text = customer.Category;
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            //the user did not select a customer
            if (lblCustomerIdForDelete.Text == "")
            {
                MessageBox.Show("Customer not chosen", "Message");
                return;
            }

            //get confirmation before delete 
            string messageBeforeDelete = "The following customer will be deleted:\n\n" +
                "Customer Id : " + lblCustomerIdForDelete.Text + "\n" +
                "Customer name : " + lblCustomerName.Text + "\n" +
                "Sum of purchases : " + lblSumOfPurchases.Text + "\n" +
                "City : " + lblCity.Text + "\n" +
                "Telephone : " + lblTelephone.Text + "\n" +
                "Account manager : " + lblAccountManager.Text + "\n" +
                "Category : " + lblCategory.Text + "\n\n" +
                "Are you sure?";

            DialogResult dialogResult = MessageBox.Show(messageBeforeDelete,
                "Are You Sure?", MessageBoxButtons.YesNo);
            
            //the user confirmed the delete
            if (dialogResult == DialogResult.Yes)
            {
                blManager.DeleteCustomer(int.Parse(lblCustomerIdForDelete.Text));
                ClearFields();
            }
            //the user cancelled
            else
            {
                MessageBox.Show("Delete operation cancelled", "Cancel");
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            //the user did not select a customer
            if (lblCustomerIdForUpdate.Text == "")
            {
                MessageBox.Show("Customer not chosen", "Message");
                return;
            }

            //the user did not change anything, so there is nothing to update
            if (lblCustomerIdForUpdate.Text == lblCustomerIdForDelete.Text &&
                txtCustomerName.Text == lblCustomerName.Text &&
                txtSumOfPurchases.Text == lblSumOfPurchases.Text &&
                txtCity.Text == lblCity.Text &&
                txtTelephone.Text == lblTelephone.Text &&
                txtAccountManager.Text == lblAccountManager.Text &&
                txtCategory.Text == lblCategory.Text)
            {
                MessageBox.Show("No field changed. Update cancelled", "Message");
                return;
            }

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

            //validation successful --> update
            Customer customer = new Customer();
            customer.Id = int.Parse(lblCustomerIdForUpdate.Text);
            customer.CustomerName = txtCustomerName.Text;
            customer.SumOfPurchases = int.Parse(txtSumOfPurchases.Text);
            customer.City = txtCity.Text;
            customer.Telephone = txtTelephone.Text;
            customer.AccountManager = txtAccountManager.Text;
            customer.Category = txtCategory.Text;

            blManager.UpdateCustomer(customer);
            ClearFields();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            lblCustomerIdForUpdate.Text = "";
            lblCustomerIdForDelete.Text = "";

            txtCustomerName.Text = "";
            lblCustomerName.Text = "";

            txtSumOfPurchases.Text = "";
            lblSumOfPurchases.Text = "";

            txtCity.Text = "";
            lblCity.Text = "";

            txtTelephone.Text = "";
            lblTelephone.Text = "";

            txtAccountManager.Text = "";
            lblAccountManager.Text = "";

            txtCategory.Text = "";
            lblCategory.Text = "";
        }
    }
}
