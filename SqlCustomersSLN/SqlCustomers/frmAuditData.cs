using SqlCustomersBLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SqlCustomers
{
    public partial class frmAuditData : Form
    {
        //create a business-logic manager
        SqlCustomersBLManager blManager = new SqlCustomersBLManager();

        private DataTable GetTableForOperation()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ValueMember");
            dt.Columns.Add("DisplayMember");

            dt.Rows.Add("Any operation", "Any operation");
            dt.Rows.Add("INSERT", "INSERT");
            dt.Rows.Add("UPDATE", "UPDATE");
            dt.Rows.Add("DELETE", "DELETE");

            return dt;
        }

        private DataTable GetTableForSortColumn()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ValueMember");
            dt.Columns.Add("DisplayMember");

            dt.Rows.Add("Id", "Id");
            dt.Rows.Add("CustomerId", "CustomerId");
            dt.Rows.Add("AuditData", "AuditData");
            dt.Rows.Add("Operation", "Operation");

            return dt;
        }

        private DataTable GetTableForSortDirection()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ValueMember");
            dt.Columns.Add("DisplayMember");

            dt.Rows.Add("ASCENDING", "ASCENDING");
            dt.Rows.Add("DESCENDING", "DESCENDING");

            return dt;
        }

        public frmAuditData()
        {
            InitializeComponent();

            //prepare lists
            DataTable dtForOperation = GetTableForOperation();
            cmbOperation.DataSource = dtForOperation;
            cmbOperation.ValueMember = "ValueMember";
            cmbOperation.DisplayMember = "DisplayMember";

            DataTable dtForSortColumn = GetTableForSortColumn();
            cmbSortColumn.DataSource = dtForSortColumn;
            cmbSortColumn.ValueMember = "ValueMember";
            cmbSortColumn.DisplayMember = "DisplayMember";

            DataTable dtForSortDirection = GetTableForSortDirection();
            cmbSortDirection.DataSource = dtForSortDirection;
            cmbSortDirection.ValueMember = "ValueMember";
            cmbSortDirection.DisplayMember = "DisplayMember";

            //disable buttons
            btnFiveBackward.Enabled = false;
            btnOneBackward.Enabled = false;
            btnOneForward.Enabled = false;
            btnFiveForward.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int x;
            if (txtCustomerId.Text != "")
            {
                //if the textbox is not empty, it must contain a number
                if (!int.TryParse(txtCustomerId.Text, out x))
                {
                    MessageBox.Show("Please enter a valid customer id", "Invalid Input");
                    txtCustomerId.Focus();
                    txtCustomerId.SelectAll();
                    return;
                }    
            }

            int currentPage, numberOfPages;
            string canMoveFivePagesBackward, canMoveOnePageBackward,
                canMoveOnePageForward, canMoveFivePagesForward;
            lblPage.Text = "Page";
            lblOf.Text = "of";

            //insert values to search labels
            lblCustomerId.Text = txtCustomerId.Text;
            lblOperation.Text = cmbOperation.SelectedValue.ToString();
            lblSortColumn.Text = cmbSortColumn.SelectedValue.ToString();
            lblSortDirection.Text = cmbSortDirection.SelectedValue.ToString();

            //get data (the search results)
            List<CustomerAuditData> customerAuditDatas = GetCustomersAuditDataList(
                1,
                out currentPage,
                out numberOfPages,
                out canMoveFivePagesBackward,
                out canMoveOnePageBackward,
                out canMoveOnePageForward,
                out canMoveFivePagesForward);

            //display search results, and enable or disable buttons
            SetControlsState(customerAuditDatas, currentPage, numberOfPages,
                canMoveFivePagesBackward, canMoveOnePageBackward,
                canMoveOnePageForward, canMoveFivePagesForward);
        }

        private void SetControlsState(List<CustomerAuditData> customerAuditDatas,
            int currentPage, int numberOfPages,
            string canMoveFivePagesBackward, string canMoveOnePageBackward,
            string canMoveOnePageForward, string canMoveFivePagesForward)
        {
            dgvCustomersAuditData.DataSource = customerAuditDatas;
            lblCurrentPage.Text = currentPage.ToString();
            lblNumberOfPages.Text = numberOfPages.ToString();

            btnFiveBackward.Enabled = canMoveFivePagesBackward == "yes";
            btnOneBackward.Enabled = canMoveOnePageBackward == "yes";
            btnOneForward.Enabled = canMoveOnePageForward == "yes";
            btnFiveForward.Enabled = canMoveFivePagesForward == "yes";
        }

        private void PerformPaging(int paging)
        {
            int currentPage, numberOfPages;
            string canMoveFivePagesBackward, canMoveOnePageBackward,
                canMoveOnePageForward, canMoveFivePagesForward;

            //get data (the search results)
            List<CustomerAuditData> customerAuditDatas = GetCustomersAuditDataList(
                int.Parse(lblCurrentPage.Text) + paging,
                out currentPage,
                out numberOfPages,
                out canMoveFivePagesBackward,
                out canMoveOnePageBackward,
                out canMoveOnePageForward,
                out canMoveFivePagesForward);

            //display search results, and enable or disable buttons
            SetControlsState(customerAuditDatas, currentPage, numberOfPages,
                canMoveFivePagesBackward, canMoveOnePageBackward,
                canMoveOnePageForward, canMoveFivePagesForward);
        }

        private void btnOneForward_Click(object sender, EventArgs e)
        {
            PerformPaging(1);
        }

        private void btnFiveForward_Click(object sender, EventArgs e)
        {
            PerformPaging(5);
        }

        private void btnOneBackward_Click(object sender, EventArgs e)
        {
            PerformPaging(-1);
        }

        private void btnFiveBackward_Click(object sender, EventArgs e)
        {
            PerformPaging(-5);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        //get data from DB
        private List<CustomerAuditData> GetCustomersAuditDataList(int pageNumber, 
            out int currentPage, out int numberOfPages,
            out string canMoveFivePagesBackward, out string canMoveOnePageBackward,
            out string canMoveOnePageForward, out string canMoveFivePagesForward)
        {
            int? customerId = null;
            if (lblCustomerId.Text != "")
                customerId = int.Parse(lblCustomerId.Text);

            return blManager.GetCustomersAuditData(
                customerId,
                (lblOperation.Text != "Any operation") ? lblOperation.Text : null,
                lblSortColumn.Text,
                GetDirectionShortString(lblSortDirection.Text),
                pageNumber,
                10,
                out currentPage,
                out numberOfPages,
                out canMoveFivePagesBackward,
                out canMoveOnePageBackward,
                out canMoveOnePageForward,
                out canMoveFivePagesForward);
        }

        private string GetDirectionShortString(string directionLongString)
        {
            if (directionLongString.ToLower() == "descending")
                return "DESC";

            return "ASC";
        }
    }
}
