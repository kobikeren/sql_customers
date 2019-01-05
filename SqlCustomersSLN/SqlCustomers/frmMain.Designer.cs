namespace SqlCustomers
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAccountManager = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnSearchCustomers1 = new System.Windows.Forms.Button();
            this.cmbSortColumn = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSortDirection = new System.Windows.Forms.ComboBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAccountManager = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSortColumn = new System.Windows.Forms.Label();
            this.lblSortDirection = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnFiveBackward = new System.Windows.Forms.Button();
            this.btnOneBackward = new System.Windows.Forms.Button();
            this.btnOneForward = new System.Windows.Forms.Button();
            this.btnFiveForward = new System.Windows.Forms.Button();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.lblNumberOfPages = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbLevelOfPurchases = new System.Windows.Forms.ComboBox();
            this.btnSearchCustomers2 = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblSumForLevel = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblOf = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account manager:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(144, 14);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerName.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(323, 14);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 22);
            this.txtCity.TabIndex = 5;
            // 
            // txtAccountManager
            // 
            this.txtAccountManager.Location = new System.Drawing.Point(143, 51);
            this.txtAccountManager.Name = "txtAccountManager";
            this.txtAccountManager.Size = new System.Drawing.Size(100, 22);
            this.txtAccountManager.TabIndex = 6;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(323, 51);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(100, 22);
            this.txtCategory.TabIndex = 7;
            // 
            // btnSearchCustomers1
            // 
            this.btnSearchCustomers1.Location = new System.Drawing.Point(21, 84);
            this.btnSearchCustomers1.Name = "btnSearchCustomers1";
            this.btnSearchCustomers1.Size = new System.Drawing.Size(101, 23);
            this.btnSearchCustomers1.TabIndex = 8;
            this.btnSearchCustomers1.Text = "New Search";
            this.btnSearchCustomers1.UseVisualStyleBackColor = true;
            this.btnSearchCustomers1.Click += new System.EventHandler(this.btnSearchCustomers1_Click);
            // 
            // cmbSortColumn
            // 
            this.cmbSortColumn.FormattingEnabled = true;
            this.cmbSortColumn.Location = new System.Drawing.Point(601, 13);
            this.cmbSortColumn.Name = "cmbSortColumn";
            this.cmbSortColumn.Size = new System.Drawing.Size(121, 24);
            this.cmbSortColumn.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sort column:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sort direction:";
            // 
            // cmbSortDirection
            // 
            this.cmbSortDirection.FormattingEnabled = true;
            this.cmbSortDirection.Location = new System.Drawing.Point(601, 50);
            this.cmbSortDirection.Name = "cmbSortDirection";
            this.cmbSortDirection.Size = new System.Drawing.Size(121, 24);
            this.cmbSortDirection.TabIndex = 12;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomerName.Location = new System.Drawing.Point(143, 143);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(100, 23);
            this.lblCustomerName.TabIndex = 13;
            // 
            // lblCity
            // 
            this.lblCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCity.Location = new System.Drawing.Point(323, 143);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(100, 23);
            this.lblCity.TabIndex = 14;
            // 
            // lblAccountManager
            // 
            this.lblAccountManager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccountManager.Location = new System.Drawing.Point(143, 180);
            this.lblAccountManager.Name = "lblAccountManager";
            this.lblAccountManager.Size = new System.Drawing.Size(100, 23);
            this.lblAccountManager.TabIndex = 15;
            // 
            // lblCategory
            // 
            this.lblCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCategory.Location = new System.Drawing.Point(323, 180);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 23);
            this.lblCategory.TabIndex = 16;
            // 
            // lblSortColumn
            // 
            this.lblSortColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSortColumn.Location = new System.Drawing.Point(601, 143);
            this.lblSortColumn.Name = "lblSortColumn";
            this.lblSortColumn.Size = new System.Drawing.Size(121, 23);
            this.lblSortColumn.TabIndex = 17;
            // 
            // lblSortDirection
            // 
            this.lblSortDirection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSortDirection.Location = new System.Drawing.Point(601, 180);
            this.lblSortDirection.Name = "lblSortDirection";
            this.lblSortDirection.Size = new System.Drawing.Size(121, 23);
            this.lblSortDirection.TabIndex = 18;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(14, 219);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(1064, 342);
            this.dgvCustomers.TabIndex = 19;
            // 
            // btnFiveBackward
            // 
            this.btnFiveBackward.Location = new System.Drawing.Point(21, 587);
            this.btnFiveBackward.Name = "btnFiveBackward";
            this.btnFiveBackward.Size = new System.Drawing.Size(75, 23);
            this.btnFiveBackward.TabIndex = 20;
            this.btnFiveBackward.Text = "<<<<<";
            this.btnFiveBackward.UseVisualStyleBackColor = true;
            this.btnFiveBackward.Click += new System.EventHandler(this.btnFiveBackward_Click);
            // 
            // btnOneBackward
            // 
            this.btnOneBackward.Location = new System.Drawing.Point(102, 587);
            this.btnOneBackward.Name = "btnOneBackward";
            this.btnOneBackward.Size = new System.Drawing.Size(75, 23);
            this.btnOneBackward.TabIndex = 21;
            this.btnOneBackward.Text = "<";
            this.btnOneBackward.UseVisualStyleBackColor = true;
            this.btnOneBackward.Click += new System.EventHandler(this.btnOneBackward_Click);
            // 
            // btnOneForward
            // 
            this.btnOneForward.Location = new System.Drawing.Point(323, 587);
            this.btnOneForward.Name = "btnOneForward";
            this.btnOneForward.Size = new System.Drawing.Size(75, 23);
            this.btnOneForward.TabIndex = 22;
            this.btnOneForward.Text = ">";
            this.btnOneForward.UseVisualStyleBackColor = true;
            this.btnOneForward.Click += new System.EventHandler(this.btnOneForward_Click);
            // 
            // btnFiveForward
            // 
            this.btnFiveForward.Location = new System.Drawing.Point(410, 587);
            this.btnFiveForward.Name = "btnFiveForward";
            this.btnFiveForward.Size = new System.Drawing.Size(75, 23);
            this.btnFiveForward.TabIndex = 23;
            this.btnFiveForward.Text = ">>>>>";
            this.btnFiveForward.UseVisualStyleBackColor = true;
            this.btnFiveForward.Click += new System.EventHandler(this.btnFiveForward_Click);
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.AutoSize = true;
            this.lblCurrentPage.Location = new System.Drawing.Point(227, 590);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(0, 17);
            this.lblCurrentPage.TabIndex = 24;
            // 
            // lblNumberOfPages
            // 
            this.lblNumberOfPages.AutoSize = true;
            this.lblNumberOfPages.Location = new System.Drawing.Point(287, 590);
            this.lblNumberOfPages.Name = "lblNumberOfPages";
            this.lblNumberOfPages.Size = new System.Drawing.Size(0, 17);
            this.lblNumberOfPages.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Fuchsia;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(14, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1064, 22);
            this.label7.TabIndex = 26;
            this.label7.Text = "Search details:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbLevelOfPurchases
            // 
            this.cmbLevelOfPurchases.FormattingEnabled = true;
            this.cmbLevelOfPurchases.Location = new System.Drawing.Point(941, 45);
            this.cmbLevelOfPurchases.Name = "cmbLevelOfPurchases";
            this.cmbLevelOfPurchases.Size = new System.Drawing.Size(121, 24);
            this.cmbLevelOfPurchases.TabIndex = 27;
            // 
            // btnSearchCustomers2
            // 
            this.btnSearchCustomers2.Location = new System.Drawing.Point(961, 84);
            this.btnSearchCustomers2.Name = "btnSearchCustomers2";
            this.btnSearchCustomers2.Size = new System.Drawing.Size(101, 23);
            this.btnSearchCustomers2.TabIndex = 28;
            this.btnSearchCustomers2.Text = "New Search";
            this.btnSearchCustomers2.UseVisualStyleBackColor = true;
            this.btnSearchCustomers2.Click += new System.EventHandler(this.btnSearchCustomers2_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLevel.Location = new System.Drawing.Point(941, 143);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(121, 23);
            this.lblLevel.TabIndex = 29;
            // 
            // lblSumForLevel
            // 
            this.lblSumForLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSumForLevel.Location = new System.Drawing.Point(941, 181);
            this.lblSumForLevel.Name = "lblSumForLevel";
            this.lblSumForLevel.Size = new System.Drawing.Size(121, 23);
            this.lblSumForLevel.TabIndex = 30;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(189, 590);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(0, 17);
            this.lblPage.TabIndex = 31;
            // 
            // lblOf
            // 
            this.lblOf.AutoSize = true;
            this.lblOf.Location = new System.Drawing.Point(255, 590);
            this.lblOf.Name = "lblOf";
            this.lblOf.Size = new System.Drawing.Size(0, 17);
            this.lblOf.TabIndex = 32;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(946, 587);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 23);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(782, 587);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(126, 23);
            this.btnOptions.TabIndex = 34;
            this.btnOptions.Text = "More options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Customer name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Account manager:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(250, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "City:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(249, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 38;
            this.label11.Text = "Category:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(504, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 17);
            this.label12.TabIndex = 39;
            this.label12.Text = "Sort column:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(495, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 17);
            this.label13.TabIndex = 40;
            this.label13.Text = "Sort direction:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(893, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 17);
            this.label14.TabIndex = 41;
            this.label14.Text = "Sum of purchases - Level";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(766, 146);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 17);
            this.label15.TabIndex = 42;
            this.label15.Text = "Sum of purchases - Level";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(804, 174);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 17);
            this.label16.TabIndex = 43;
            this.label16.Text = "Sum of purchases -";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(804, 191);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 17);
            this.label17.TabIndex = 44;
            this.label17.Text = "for specified level";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 637);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblOf);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.lblSumForLevel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.btnSearchCustomers2);
            this.Controls.Add(this.cmbLevelOfPurchases);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNumberOfPages);
            this.Controls.Add(this.lblCurrentPage);
            this.Controls.Add(this.btnFiveForward);
            this.Controls.Add(this.btnOneForward);
            this.Controls.Add(this.btnOneBackward);
            this.Controls.Add(this.btnFiveBackward);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.lblSortDirection);
            this.Controls.Add(this.lblSortColumn);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblAccountManager);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.cmbSortDirection);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSortColumn);
            this.Controls.Add(this.btnSearchCustomers1);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtAccountManager);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Main Window";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAccountManager;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnSearchCustomers1;
        private System.Windows.Forms.ComboBox cmbSortColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSortDirection;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAccountManager;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSortColumn;
        private System.Windows.Forms.Label lblSortDirection;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnFiveBackward;
        private System.Windows.Forms.Button btnOneBackward;
        private System.Windows.Forms.Button btnOneForward;
        private System.Windows.Forms.Button btnFiveForward;
        private System.Windows.Forms.Label lblCurrentPage;
        private System.Windows.Forms.Label lblNumberOfPages;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbLevelOfPurchases;
        private System.Windows.Forms.Button btnSearchCustomers2;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblSumForLevel;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblOf;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

