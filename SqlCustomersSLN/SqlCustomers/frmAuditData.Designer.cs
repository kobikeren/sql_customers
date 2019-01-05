namespace SqlCustomers
{
    partial class frmAuditData
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
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.cmbSortColumn = new System.Windows.Forms.ComboBox();
            this.cmbSortDirection = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.lblSortColumn = new System.Windows.Forms.Label();
            this.lblSortDirection = new System.Windows.Forms.Label();
            this.dgvCustomersAuditData = new System.Windows.Forms.DataGridView();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.lblOf = new System.Windows.Forms.Label();
            this.lblNumberOfPages = new System.Windows.Forms.Label();
            this.btnFiveBackward = new System.Windows.Forms.Button();
            this.btnOneBackward = new System.Windows.Forms.Button();
            this.btnOneForward = new System.Windows.Forms.Button();
            this.btnFiveForward = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersAuditData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sort column:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(697, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sort direction:";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(125, 16);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerId.TabIndex = 4;
            // 
            // cmbOperation
            // 
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Location = new System.Drawing.Point(327, 15);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(121, 24);
            this.cmbOperation.TabIndex = 5;
            // 
            // cmbSortColumn
            // 
            this.cmbSortColumn.FormattingEnabled = true;
            this.cmbSortColumn.Location = new System.Drawing.Point(567, 15);
            this.cmbSortColumn.Name = "cmbSortColumn";
            this.cmbSortColumn.Size = new System.Drawing.Size(121, 24);
            this.cmbSortColumn.TabIndex = 6;
            // 
            // cmbSortDirection
            // 
            this.cmbSortDirection.FormattingEnabled = true;
            this.cmbSortDirection.Location = new System.Drawing.Point(799, 15);
            this.cmbSortDirection.Name = "cmbSortDirection";
            this.cmbSortDirection.Size = new System.Drawing.Size(121, 24);
            this.cmbSortDirection.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(49, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "New Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomerId.Location = new System.Drawing.Point(125, 123);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(100, 23);
            this.lblCustomerId.TabIndex = 9;
            // 
            // lblOperation
            // 
            this.lblOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOperation.Location = new System.Drawing.Point(327, 123);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(121, 23);
            this.lblOperation.TabIndex = 10;
            // 
            // lblSortColumn
            // 
            this.lblSortColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSortColumn.Location = new System.Drawing.Point(567, 123);
            this.lblSortColumn.Name = "lblSortColumn";
            this.lblSortColumn.Size = new System.Drawing.Size(121, 23);
            this.lblSortColumn.TabIndex = 11;
            // 
            // lblSortDirection
            // 
            this.lblSortDirection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSortDirection.Location = new System.Drawing.Point(799, 123);
            this.lblSortDirection.Name = "lblSortDirection";
            this.lblSortDirection.Size = new System.Drawing.Size(121, 23);
            this.lblSortDirection.TabIndex = 12;
            // 
            // dgvCustomersAuditData
            // 
            this.dgvCustomersAuditData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomersAuditData.Location = new System.Drawing.Point(12, 168);
            this.dgvCustomersAuditData.Name = "dgvCustomersAuditData";
            this.dgvCustomersAuditData.RowTemplate.Height = 24;
            this.dgvCustomersAuditData.Size = new System.Drawing.Size(945, 359);
            this.dgvCustomersAuditData.TabIndex = 13;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(206, 554);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(0, 17);
            this.lblPage.TabIndex = 14;
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.AutoSize = true;
            this.lblCurrentPage.Location = new System.Drawing.Point(255, 554);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(0, 17);
            this.lblCurrentPage.TabIndex = 15;
            // 
            // lblOf
            // 
            this.lblOf.AutoSize = true;
            this.lblOf.Location = new System.Drawing.Point(298, 554);
            this.lblOf.Name = "lblOf";
            this.lblOf.Size = new System.Drawing.Size(0, 17);
            this.lblOf.TabIndex = 16;
            // 
            // lblNumberOfPages
            // 
            this.lblNumberOfPages.AutoSize = true;
            this.lblNumberOfPages.Location = new System.Drawing.Point(345, 554);
            this.lblNumberOfPages.Name = "lblNumberOfPages";
            this.lblNumberOfPages.Size = new System.Drawing.Size(0, 17);
            this.lblNumberOfPages.TabIndex = 17;
            // 
            // btnFiveBackward
            // 
            this.btnFiveBackward.Location = new System.Drawing.Point(34, 551);
            this.btnFiveBackward.Name = "btnFiveBackward";
            this.btnFiveBackward.Size = new System.Drawing.Size(75, 23);
            this.btnFiveBackward.TabIndex = 18;
            this.btnFiveBackward.Text = "<<<<<";
            this.btnFiveBackward.UseVisualStyleBackColor = true;
            this.btnFiveBackward.Click += new System.EventHandler(this.btnFiveBackward_Click);
            // 
            // btnOneBackward
            // 
            this.btnOneBackward.Location = new System.Drawing.Point(125, 551);
            this.btnOneBackward.Name = "btnOneBackward";
            this.btnOneBackward.Size = new System.Drawing.Size(75, 23);
            this.btnOneBackward.TabIndex = 19;
            this.btnOneBackward.Text = "<";
            this.btnOneBackward.UseVisualStyleBackColor = true;
            this.btnOneBackward.Click += new System.EventHandler(this.btnOneBackward_Click);
            // 
            // btnOneForward
            // 
            this.btnOneForward.Location = new System.Drawing.Point(422, 551);
            this.btnOneForward.Name = "btnOneForward";
            this.btnOneForward.Size = new System.Drawing.Size(75, 23);
            this.btnOneForward.TabIndex = 20;
            this.btnOneForward.Text = ">";
            this.btnOneForward.UseVisualStyleBackColor = true;
            this.btnOneForward.Click += new System.EventHandler(this.btnOneForward_Click);
            // 
            // btnFiveForward
            // 
            this.btnFiveForward.Location = new System.Drawing.Point(514, 551);
            this.btnFiveForward.Name = "btnFiveForward";
            this.btnFiveForward.Size = new System.Drawing.Size(75, 23);
            this.btnFiveForward.TabIndex = 21;
            this.btnFiveForward.Text = ">>>>>";
            this.btnFiveForward.UseVisualStyleBackColor = true;
            this.btnFiveForward.Click += new System.EventHandler(this.btnFiveForward_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Customer Id:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Operation:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Sort column:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(697, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Sort direction:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Fuchsia;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(12, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(945, 23);
            this.label9.TabIndex = 26;
            this.label9.Text = "Search details:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(868, 551);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAuditData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 604);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFiveForward);
            this.Controls.Add(this.btnOneForward);
            this.Controls.Add(this.btnOneBackward);
            this.Controls.Add(this.btnFiveBackward);
            this.Controls.Add(this.lblNumberOfPages);
            this.Controls.Add(this.lblOf);
            this.Controls.Add(this.lblCurrentPage);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.dgvCustomersAuditData);
            this.Controls.Add(this.lblSortDirection);
            this.Controls.Add(this.lblSortColumn);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbSortDirection);
            this.Controls.Add(this.cmbSortColumn);
            this.Controls.Add(this.cmbOperation);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAuditData";
            this.Text = "Audit Data";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersAuditData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.ComboBox cmbSortColumn;
        private System.Windows.Forms.ComboBox cmbSortDirection;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label lblSortColumn;
        private System.Windows.Forms.Label lblSortDirection;
        private System.Windows.Forms.DataGridView dgvCustomersAuditData;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblCurrentPage;
        private System.Windows.Forms.Label lblOf;
        private System.Windows.Forms.Label lblNumberOfPages;
        private System.Windows.Forms.Button btnFiveBackward;
        private System.Windows.Forms.Button btnOneBackward;
        private System.Windows.Forms.Button btnOneForward;
        private System.Windows.Forms.Button btnFiveForward;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBack;
    }
}