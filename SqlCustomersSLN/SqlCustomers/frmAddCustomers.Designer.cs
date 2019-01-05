namespace SqlCustomers
{
    partial class frmAddCustomers
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
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnInsertCustomer = new System.Windows.Forms.Button();
            this.btnClearMessage = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtSumOfPurchases = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtAccountManager = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(193, 19);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(180, 23);
            this.btnClearFields.TabIndex = 0;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnInsertCustomer
            // 
            this.btnInsertCustomer.Location = new System.Drawing.Point(193, 326);
            this.btnInsertCustomer.Name = "btnInsertCustomer";
            this.btnInsertCustomer.Size = new System.Drawing.Size(180, 23);
            this.btnInsertCustomer.TabIndex = 1;
            this.btnInsertCustomer.Text = "Insert Customer";
            this.btnInsertCustomer.UseVisualStyleBackColor = true;
            this.btnInsertCustomer.Click += new System.EventHandler(this.btnInsertCustomer_Click);
            // 
            // btnClearMessage
            // 
            this.btnClearMessage.Location = new System.Drawing.Point(28, 460);
            this.btnClearMessage.Name = "btnClearMessage";
            this.btnClearMessage.Size = new System.Drawing.Size(148, 23);
            this.btnClearMessage.TabIndex = 2;
            this.btnClearMessage.Text = "Clear Message";
            this.btnClearMessage.UseVisualStyleBackColor = true;
            this.btnClearMessage.Click += new System.EventHandler(this.btnClearMessage_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(225, 460);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sum of purchases:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telephone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Account manager:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Category:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(25, 421);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 10;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(193, 61);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(180, 22);
            this.txtCustomerName.TabIndex = 11;
            // 
            // txtSumOfPurchases
            // 
            this.txtSumOfPurchases.Location = new System.Drawing.Point(193, 104);
            this.txtSumOfPurchases.Name = "txtSumOfPurchases";
            this.txtSumOfPurchases.Size = new System.Drawing.Size(180, 22);
            this.txtSumOfPurchases.TabIndex = 12;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(193, 150);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(180, 22);
            this.txtCity.TabIndex = 13;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(193, 189);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(180, 22);
            this.txtTelephone.TabIndex = 14;
            // 
            // txtAccountManager
            // 
            this.txtAccountManager.Location = new System.Drawing.Point(193, 232);
            this.txtAccountManager.Name = "txtAccountManager";
            this.txtAccountManager.Size = new System.Drawing.Size(180, 22);
            this.txtAccountManager.TabIndex = 15;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(193, 277);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(180, 22);
            this.txtCategory.TabIndex = 16;
            // 
            // frmAddCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 507);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtAccountManager);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtSumOfPurchases);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClearMessage);
            this.Controls.Add(this.btnInsertCustomer);
            this.Controls.Add(this.btnClearFields);
            this.Name = "frmAddCustomers";
            this.Text = "Add Customers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnInsertCustomer;
        private System.Windows.Forms.Button btnClearMessage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtSumOfPurchases;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtAccountManager;
        private System.Windows.Forms.TextBox txtCategory;
    }
}