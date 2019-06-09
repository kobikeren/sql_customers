using SqlCustomersBLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SqlCustomers
{
    //*******************************************************************
    //****************** Created by kobi keren **************************
    //******************     on 09/06/2019     **************************
    //*******************************************************************

    public partial class frmMain : Form
    {
        //create a business-logic manager
        SqlCustomersBLManager blManager = new SqlCustomersBLManager();

        //set search-type to not-defined
        SearchType currentSearchType = SearchType.NotDefined;

        private DataTable GetTableForSortColumn()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ValueMember");
            dt.Columns.Add("DisplayMember");

            dt.Rows.Add("Id", "Id");
            dt.Rows.Add("CustomerName", "CustomerName");
            dt.Rows.Add("SumOfPurchases", "SumOfPurchases");
            dt.Rows.Add("City", "City");
            dt.Rows.Add("Telephone", "Telephone");
            dt.Rows.Add("AccountManager", "AccountManager");
            dt.Rows.Add("Category", "Category");

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

        private DataTable GetTableForLevelOfPurchases()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ValueMember");
            dt.Columns.Add("DisplayMember");

            dt.Rows.Add("1", "Highest");
            dt.Rows.Add("2", "Second");
            dt.Rows.Add("3", "Third");
            dt.Rows.Add("4", "Fourth");
            dt.Rows.Add("5", "Fifth");
            dt.Rows.Add("6", "Sixth");
            dt.Rows.Add("7", "Seventh");
            dt.Rows.Add("8", "Eighth");
            dt.Rows.Add("9", "Ninth");
            dt.Rows.Add("10", "Tenth");

            return dt;
        }

        public frmMain()
        {
            InitializeComponent();

            //prepare lists
            DataTable dtForSortColumn = GetTableForSortColumn();
            cmbSortColumn.DataSource = dtForSortColumn;
            cmbSortColumn.ValueMember = "ValueMember";
            cmbSortColumn.DisplayMember = "DisplayMember";

            DataTable dtForSortDirection = GetTableForSortDirection();
            cmbSortDirection.DataSource = dtForSortDirection;
            cmbSortDirection.ValueMember = "ValueMember";
            cmbSortDirection.DisplayMember = "DisplayMember";

            DataTable dtForLevelOfPurchases = GetTableForLevelOfPurchases();
            cmbLevelOfPurchases.DataSource = dtForLevelOfPurchases;
            cmbLevelOfPurchases.ValueMember = "ValueMember";
            cmbLevelOfPurchases.DisplayMember = "DisplayMember";

            //disable buttons
            btnFiveBackward.Enabled = false;
            btnOneBackward.Enabled = false;
            btnOneForward.Enabled = false;
            btnFiveForward.Enabled = false;
        }

        private void btnSearchCustomers1_Click(object sender, EventArgs e)
        {
            //new search (general search)
            currentSearchType = SearchType.GeneralSearch;

            int currentPage, numberOfPages;
            string canMoveFivePagesBackward,canMoveOnePageBackward,
                canMoveOnePageForward,canMoveFivePagesForward;

            SetColorsForSearch();
            
            //insert values to search labels
            lblCustomerName.Text = txtCustomerName.Text;
            lblCity.Text = txtCity.Text;
            lblAccountManager.Text = txtAccountManager.Text;
            lblCategory.Text = txtCategory.Text;
            lblSortColumn.Text = cmbSortColumn.SelectedValue.ToString();
            lblSortDirection.Text = cmbSortDirection.SelectedValue.ToString();

            //get data (the search results)
            List<Customer> customers = GetCustomersList(1,
                out currentPage, out numberOfPages,
                out canMoveFivePagesBackward, out canMoveOnePageBackward,
                out canMoveOnePageForward, out canMoveFivePagesForward);

            //display search results, and enable or disable buttons
            SetControlsState(customers, currentPage, numberOfPages,
                canMoveFivePagesBackward, canMoveOnePageBackward,
                canMoveOnePageForward, canMoveFivePagesForward);
        }

        private void btnSearchCustomers2_Click(object sender, EventArgs e)
        {
            //new search (by level of sum of purchases)
            currentSearchType = SearchType.ByLevelOfSumOfPurchases;

            int currentPage, numberOfPages, sumOfPurchasesForLevel;
            string canMoveFivePagesBackward, canMoveOnePageBackward,
                canMoveOnePageForward, canMoveFivePagesForward;

            SetColorsForSearch();

            //insert values to search labels
            lblLevel.Text = cmbLevelOfPurchases.Text;
            lblSortColumn.Text = cmbSortColumn.SelectedValue.ToString();
            lblSortDirection.Text = cmbSortDirection.SelectedValue.ToString();

            //get data (the search results)
            List<Customer> customers = GetCustomersListBySumOfPurchasesLevel(1,
                out sumOfPurchasesForLevel, out currentPage, out numberOfPages,
                out canMoveFivePagesBackward, out canMoveOnePageBackward,
                out canMoveOnePageForward, out canMoveFivePagesForward);

            lblSumForLevel.Text = sumOfPurchasesForLevel.ToString();

            //display search results, and enable or disable buttons
            SetControlsState(customers, currentPage, numberOfPages,
                canMoveFivePagesBackward, canMoveOnePageBackward,
                canMoveOnePageForward, canMoveFivePagesForward);
        }

        private void SetControlsState(List<Customer> customers,
            int currentPage, int numberOfPages,
            string canMoveFivePagesBackward, string canMoveOnePageBackward,
            string canMoveOnePageForward, string canMoveFivePagesForward)
        {
            dgvCustomers.DataSource = customers;
            lblCurrentPage.Text = currentPage.ToString();
            lblNumberOfPages.Text = numberOfPages.ToString();

            btnFiveBackward.Enabled = canMoveFivePagesBackward == "yes";
            btnOneBackward.Enabled = canMoveOnePageBackward == "yes";
            btnOneForward.Enabled = canMoveOnePageForward == "yes";
            btnFiveForward.Enabled = canMoveFivePagesForward == "yes";
        }

        private void PerformPaging(int paging)
        {
            int currentPage, numberOfPages, sumOfPurchasesForLevel;
            string canMoveFivePagesBackward, canMoveOnePageBackward,
                canMoveOnePageForward, canMoveFivePagesForward;
            List<Customer> customers;

            if (currentSearchType == SearchType.GeneralSearch)
            {
                //get data (the search results)
                customers = GetCustomersList(
                    int.Parse(lblCurrentPage.Text) + paging,
                    out currentPage,
                    out numberOfPages,
                    out canMoveFivePagesBackward,
                    out canMoveOnePageBackward,
                    out canMoveOnePageForward,
                    out canMoveFivePagesForward);
            }
            else
            {
                //get data (the search results)
                customers = GetCustomersListBySumOfPurchasesLevel(    
                    int.Parse(lblCurrentPage.Text) + paging,
                    out sumOfPurchasesForLevel,
                    out currentPage,
                    out numberOfPages,
                    out canMoveFivePagesBackward,
                    out canMoveOnePageBackward,
                    out canMoveOnePageForward,
                    out canMoveFivePagesForward);
            }

            //display search results, and enable or disable buttons
            SetControlsState(customers, currentPage, numberOfPages,
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

        private void SetColorsForSearch()
        {
            lblPage.Text = "Page";
            lblOf.Text = "of";
            lblSortColumn.BackColor = Color.LightGreen;
            lblSortDirection.BackColor = Color.LightGreen;

            if (currentSearchType == SearchType.GeneralSearch)
            {
                lblCustomerName.BackColor = Color.LightGreen;
                lblCity.BackColor = Color.LightGreen;
                lblAccountManager.BackColor = Color.LightGreen;
                lblCategory.BackColor = Color.LightGreen;

                lblLevel.BackColor = Color.PaleVioletRed;
                lblSumForLevel.BackColor = Color.PaleVioletRed;
            }
            if (currentSearchType == SearchType.ByLevelOfSumOfPurchases)
            {
                lblLevel.BackColor = Color.LightGreen;
                lblSumForLevel.BackColor = Color.LightGreen;
                
                lblCustomerName.BackColor = Color.PaleVioletRed;
                lblCity.BackColor = Color.PaleVioletRed;
                lblAccountManager.BackColor = Color.PaleVioletRed;
                lblCategory.BackColor = Color.PaleVioletRed;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu1 = new frmMenu();
            Hide();
            frmMenu1.ShowDialog();
            Show();
        }

        //get data from DB
        private List<Customer> GetCustomersList(int pageNumber,
            out int currentPage, out int numberOfPages,
            out string canMoveFivePagesBackward, out string canMoveOnePageBackward,
            out string canMoveOnePageForward, out string canMoveFivePagesForward)
        {
            return blManager.GetCustomers(
                (lblCustomerName.Text != "") ? lblCustomerName.Text : null,
                (lblCity.Text != "") ? lblCity.Text : null,
                (lblAccountManager.Text != "") ? lblAccountManager.Text : null,
                (lblCategory.Text != "") ? lblCategory.Text : null,
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

        //get data from DB
        private List<Customer> GetCustomersListBySumOfPurchasesLevel(int pageNumber,
            out int sumOfPurchasesForLevel, out int currentPage, out int numberOfPages,
            out string canMoveFivePagesBackward, out string canMoveOnePageBackward,
            out string canMoveOnePageForward, out string canMoveFivePagesForward)
        {
            return blManager.GetCustomersBySumOfPurchasesLevel(
                int.Parse(cmbLevelOfPurchases.SelectedValue.ToString()),
                lblSortColumn.Text,
                GetDirectionShortString(lblSortDirection.Text),
                pageNumber,
                10,
                out sumOfPurchasesForLevel,
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
